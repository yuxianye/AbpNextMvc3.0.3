using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseWorkLocation.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseWorkLocation
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseWorkLocationViewModel ViewModel { get; set; }

        private readonly IEnterpriseWorkLocationAppService _service;

        public CreateModalModel(IEnterpriseWorkLocationAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseWorkLocationViewModel, CreateUpdateEnterpriseWorkLocationDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}