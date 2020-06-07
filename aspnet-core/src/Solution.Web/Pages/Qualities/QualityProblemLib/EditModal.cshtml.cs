using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Qualities;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityProblemLib.ViewModels;
namespace Solution.Web.Pages.Qualities.QualityProblemLib
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditQualityProblemLibViewModel ViewModel { get; set; }

        private readonly IQualityProblemLibAppService _service;

        public EditModalModel(IQualityProblemLibAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<QualityProblemLibDto, CreateEditQualityProblemLibViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditQualityProblemLibViewModel, CreateUpdateQualityProblemLibDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}