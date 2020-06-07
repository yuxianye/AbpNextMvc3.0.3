using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Materials;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.Material.ViewModels;
namespace Solution.Web.Pages.Materials.Material
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditMaterialViewModel ViewModel { get; set; }

        private readonly IMaterialAppService _service;

        public CreateModalModel(IMaterialAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMaterialViewModel, CreateUpdateMaterialDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}