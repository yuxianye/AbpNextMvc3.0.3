using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Materials;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.Material.ViewModels;
namespace Solution.Web.Pages.Materials.Material
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditMaterialViewModel ViewModel { get; set; }

        private readonly IMaterialAppService _service;

        public EditModalModel(IMaterialAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<MaterialDto, CreateEditMaterialViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMaterialViewModel, CreateUpdateMaterialDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}