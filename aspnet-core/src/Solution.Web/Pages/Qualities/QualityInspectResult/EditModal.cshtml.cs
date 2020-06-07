using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Qualities;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityInspectResult.ViewModels;
namespace Solution.Web.Pages.Qualities.QualityInspectResult
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditQualityInspectResultViewModel ViewModel { get; set; }

        private readonly IQualityInspectResultAppService _service;

        public EditModalModel(IQualityInspectResultAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<QualityInspectResultDto, CreateEditQualityInspectResultViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditQualityInspectResultViewModel, CreateUpdateQualityInspectResultDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}