using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Orders;
using Solution.Orders.Dtos;
using Solution.Web.Pages.Orders.Order.ViewModels;
namespace Solution.Web.Pages.Orders.Order
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditOrderViewModel ViewModel { get; set; }

        private readonly IOrderAppService _service;

        public CreateModalModel(IOrderAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditOrderViewModel, CreateUpdateOrderDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}