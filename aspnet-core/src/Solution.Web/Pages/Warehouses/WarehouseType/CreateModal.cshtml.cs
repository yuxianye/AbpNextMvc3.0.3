using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WarehouseType.ViewModels;
namespace Solution.Web.Pages.Warehouses.WarehouseType
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditWarehouseTypeViewModel ViewModel { get; set; }

        private readonly IWarehouseTypeAppService _service;

        public CreateModalModel(IWarehouseTypeAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWarehouseTypeViewModel, CreateUpdateWarehouseTypeDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}