using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Customers;
using Solution.Customers.Dtos;
using Solution.Web.Pages.Customers.Customer.ViewModels;
namespace Solution.Web.Pages.Customers.Customer
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditCustomerViewModel ViewModel { get; set; }

        private readonly ICustomerAppService _service;

        public CreateModalModel(ICustomerAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerViewModel, CreateUpdateCustomerDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}