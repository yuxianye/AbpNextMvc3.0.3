using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.Enterprise.ViewModels;
namespace Solution.Web.Pages.Enterprises.Enterprise
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseViewModel ViewModel { get; set; }

        private readonly IEnterpriseAppService _service;

        public CreateModalModel(IEnterpriseAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseViewModel, CreateUpdateEnterpriseDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}