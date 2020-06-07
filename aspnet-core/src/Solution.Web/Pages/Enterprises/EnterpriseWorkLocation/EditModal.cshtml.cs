using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseWorkLocation.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseWorkLocation
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEnterpriseWorkLocationViewModel ViewModel { get; set; }

        private readonly IEnterpriseWorkLocationAppService _service;

        public EditModalModel(IEnterpriseWorkLocationAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EnterpriseWorkLocationDto, CreateEditEnterpriseWorkLocationViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseWorkLocationViewModel, CreateUpdateEnterpriseWorkLocationDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}