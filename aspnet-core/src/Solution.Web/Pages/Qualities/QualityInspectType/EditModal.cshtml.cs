using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Qualities;
using Solution.Qualities.Dtos;
using Solution.Web.Pages.Qualities.QualityInspectType.ViewModels;
namespace Solution.Web.Pages.Qualities.QualityInspectType
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditQualityInspectTypeViewModel ViewModel { get; set; }

        private readonly IQualityInspectTypeAppService _service;

        public EditModalModel(IQualityInspectTypeAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<QualityInspectTypeDto, CreateEditQualityInspectTypeViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditQualityInspectTypeViewModel, CreateUpdateQualityInspectTypeDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}