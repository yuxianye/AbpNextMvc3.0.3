using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseProductionLine.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseProductionLine
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseProductionLineViewModel ViewModel { get; set; }

        private readonly IEnterpriseProductionLineAppService _service;

        public CreateModalModel(IEnterpriseProductionLineAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseProductionLineViewModel, CreateUpdateEnterpriseProductionLineDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}