using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Qualities;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityInspectResult.ViewModels;
namespace Solution.Web.Pages.Qualities.QualityInspectResult
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditQualityInspectResultViewModel ViewModel { get; set; }

        private readonly IQualityInspectResultAppService _service;

        public CreateModalModel(IQualityInspectResultAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditQualityInspectResultViewModel, CreateUpdateQualityInspectResultDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}