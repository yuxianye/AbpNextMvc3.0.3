using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Orders;
using Solution.Orders.Dtos;
using Solution.Web.Pages.Orders.Order.ViewModels;
namespace Solution.Web.Pages.Orders.Order
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditOrderViewModel ViewModel { get; set; }

        private readonly IOrderAppService _service;

        public EditModalModel(IOrderAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<OrderDto, CreateEditOrderViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditOrderViewModel, CreateUpdateOrderDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}