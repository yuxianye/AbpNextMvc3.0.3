using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseWorkCenter.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseWorkCenter
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEnterpriseWorkCenterViewModel ViewModel { get; set; }

        private readonly IEnterpriseWorkCenterAppService _service;

        public EditModalModel(IEnterpriseWorkCenterAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EnterpriseWorkCenterDto, CreateEditEnterpriseWorkCenterViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseWorkCenterViewModel, CreateUpdateEnterpriseWorkCenterDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}