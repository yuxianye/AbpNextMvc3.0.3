using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Orders;
using Solution.Orders.Dtos;
using Solution.Web.Pages.Orders.OrderStatus.ViewModels;
namespace Solution.Web.Pages.Orders.OrderStatus
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditOrderStatusViewModel ViewModel { get; set; }

        private readonly IOrderStatusAppService _service;

        public EditModalModel(IOrderStatusAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<OrderStatusDto, CreateEditOrderStatusViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditOrderStatusViewModel, CreateUpdateOrderStatusDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}