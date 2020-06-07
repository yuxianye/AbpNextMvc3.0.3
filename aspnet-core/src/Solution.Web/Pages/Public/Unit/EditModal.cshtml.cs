using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Public;
using Solution.Public.Dtos;
using Solution.Web.Pages.Public.Unit.ViewModels;
namespace Solution.Web.Pages.Public.Unit
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditUnitViewModel ViewModel { get; set; }

        private readonly IUnitAppService _service;

        public EditModalModel(IUnitAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<UnitDto, CreateEditUnitViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditUnitViewModel, CreateUpdateUnitDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}