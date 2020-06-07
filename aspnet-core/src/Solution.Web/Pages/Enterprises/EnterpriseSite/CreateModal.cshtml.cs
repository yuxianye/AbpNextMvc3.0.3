using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseSite.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseSite
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseSiteViewModel ViewModel { get; set; }

        private readonly IEnterpriseSiteAppService _service;

        public CreateModalModel(IEnterpriseSiteAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseSiteViewModel, CreateUpdateEnterpriseSiteDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}