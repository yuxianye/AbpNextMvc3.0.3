using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Qualities;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityInspectType.ViewModels;
namespace Solution.Web.Pages.Qualities.QualityInspectType
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditQualityInspectTypeViewModel ViewModel { get; set; }

        private readonly IQualityInspectTypeAppService _service;

        public CreateModalModel(IQualityInspectTypeAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditQualityInspectTypeViewModel, CreateUpdateQualityInspectTypeDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}