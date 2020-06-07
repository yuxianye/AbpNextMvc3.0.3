using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseWorkCenter.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseWorkCenter
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseWorkCenterViewModel ViewModel { get; set; }

        private readonly IEnterpriseWorkCenterAppService _service;

        public CreateModalModel(IEnterpriseWorkCenterAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseWorkCenterViewModel, CreateUpdateEnterpriseWorkCenterDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}