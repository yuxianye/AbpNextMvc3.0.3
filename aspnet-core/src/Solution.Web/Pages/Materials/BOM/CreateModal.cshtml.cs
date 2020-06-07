using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Materials;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.BOM.ViewModels;
namespace Solution.Web.Pages.Materials.BOM
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditBOMViewModel ViewModel { get; set; }

        private readonly IBOMAppService _service;

        public CreateModalModel(IBOMAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditBOMViewModel, CreateUpdateBOMDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}