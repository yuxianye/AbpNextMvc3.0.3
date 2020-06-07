using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Public;
using Solution.Public.Dtos;
using Solution.Web.Pages.Public.Unit.ViewModels;
namespace Solution.Web.Pages.Public.Unit
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditUnitViewModel ViewModel { get; set; }

        private readonly IUnitAppService _service;

        public CreateModalModel(IUnitAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditUnitViewModel, CreateUpdateUnitDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}