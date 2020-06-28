using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WarehouseLocation.ViewModels;
namespace Solution.Web.Pages.Warehouses.WarehouseLocation
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditWarehouseLocationViewModel ViewModel { get; set; }

        private readonly IWarehouseLocationAppService _service;

        public CreateModalModel(IWarehouseLocationAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWarehouseLocationViewModel, CreateUpdateWarehouseLocationDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}