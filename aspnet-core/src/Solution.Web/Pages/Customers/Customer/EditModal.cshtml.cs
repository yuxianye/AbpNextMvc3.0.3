using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Customers;
using Solution.Customers.Dtos;
using Solution.Web.Pages.Customers.Customer.ViewModels;
namespace Solution.Web.Pages.Customers.Customer
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditCustomerViewModel ViewModel { get; set; }

        private readonly ICustomerAppService _service;

        public EditModalModel(ICustomerAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<CustomerDto, CreateEditCustomerViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerViewModel, CreateUpdateCustomerDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}