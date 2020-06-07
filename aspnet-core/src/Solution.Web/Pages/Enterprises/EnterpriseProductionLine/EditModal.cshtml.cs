using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseProductionLine.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseProductionLine
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEnterpriseProductionLineViewModel ViewModel { get; set; }

        private readonly IEnterpriseProductionLineAppService _service;

        public EditModalModel(IEnterpriseProductionLineAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EnterpriseProductionLineDto, CreateEditEnterpriseProductionLineViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseProductionLineViewModel, CreateUpdateEnterpriseProductionLineDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}