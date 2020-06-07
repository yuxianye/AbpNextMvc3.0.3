using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseArea.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseArea
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseAreaViewModel ViewModel { get; set; }

        private readonly IEnterpriseAreaAppService _service;

        public CreateModalModel(IEnterpriseAreaAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseAreaViewModel, CreateUpdateEnterpriseAreaDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}