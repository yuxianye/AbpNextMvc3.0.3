using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WarehouseArea.ViewModels;
namespace Solution.Web.Pages.Warehouses.WarehouseArea
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditWarehouseAreaViewModel ViewModel { get; set; }

        private readonly IWarehouseAreaAppService _service;

        public CreateModalModel(IWarehouseAreaAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWarehouseAreaViewModel, CreateUpdateWarehouseAreaDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}