using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.Warehouse.ViewModels;
namespace Solution.Web.Pages.Warehouses.Warehouse
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditWarehouseViewModel ViewModel { get; set; }

        private readonly IWarehouseAppService _service;

        public CreateModalModel(IWarehouseAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWarehouseViewModel, CreateUpdateWarehouseDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}