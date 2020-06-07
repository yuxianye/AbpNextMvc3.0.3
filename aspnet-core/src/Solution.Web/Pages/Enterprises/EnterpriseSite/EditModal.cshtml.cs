using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseSite.ViewModels;
namespace Solution.Web.Pages.Enterprises.EnterpriseSite
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEnterpriseSiteViewModel ViewModel { get; set; }

        private readonly IEnterpriseSiteAppService _service;

        public EditModalModel(IEnterpriseSiteAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EnterpriseSiteDto, CreateEditEnterpriseSiteViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseSiteViewModel, CreateUpdateEnterpriseSiteDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}