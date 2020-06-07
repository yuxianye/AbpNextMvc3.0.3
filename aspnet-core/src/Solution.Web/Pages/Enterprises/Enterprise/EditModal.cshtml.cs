using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.Enterprise.ViewModels;
namespace Solution.Web.Pages.Enterprises.Enterprise
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEnterpriseViewModel ViewModel { get; set; }

        private readonly IEnterpriseAppService _service;

        public EditModalModel(IEnterpriseAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EnterpriseDto, CreateEditEnterpriseViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseViewModel, CreateUpdateEnterpriseDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}