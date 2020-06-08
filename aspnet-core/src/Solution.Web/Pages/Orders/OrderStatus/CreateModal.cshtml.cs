using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Orders;
using Solution.Orders.Dtos;
using Solution.Web.Pages.Orders.OrderStatus.ViewModels;
namespace Solution.Web.Pages.Orders.OrderStatus
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditOrderStatusViewModel ViewModel { get; set; }

        private readonly IOrderStatusAppService _service;

        public CreateModalModel(IOrderStatusAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditOrderStatusViewModel, CreateUpdateOrderStatusDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}