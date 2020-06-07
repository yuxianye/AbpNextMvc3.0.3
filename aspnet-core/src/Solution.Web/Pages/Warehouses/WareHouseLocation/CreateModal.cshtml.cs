using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WareHouseLocation.ViewModels;
namespace Solution.Web.Pages.Warehouses.WareHouseLocation
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditWareHouseLocationViewModel ViewModel { get; set; }

        private readonly IWareHouseLocationAppService _service;

        public CreateModalModel(IWareHouseLocationAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWareHouseLocationViewModel, CreateUpdateWareHouseLocationDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}