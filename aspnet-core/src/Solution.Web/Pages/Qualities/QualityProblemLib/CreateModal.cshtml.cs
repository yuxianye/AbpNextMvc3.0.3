using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Qualities;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityProblemLib.ViewModels;
namespace Solution.Web.Pages.Qualities.QualityProblemLib
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditQualityProblemLibViewModel ViewModel { get; set; }

        private readonly IQualityProblemLibAppService _service;

        public CreateModalModel(IQualityProblemLibAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditQualityProblemLibViewModel, CreateUpdateQualityProblemLibDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}