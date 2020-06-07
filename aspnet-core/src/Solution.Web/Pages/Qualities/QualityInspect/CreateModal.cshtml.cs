using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Qualities;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityInspect.ViewModels;
namespace Solution.Web.Pages.Qualities.QualityInspect
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditQualityInspectViewModel ViewModel { get; set; }

        private readonly IQualityInspectAppService _service;

        public CreateModalModel(IQualityInspectAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditQualityInspectViewModel, CreateUpdateQualityInspectDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}