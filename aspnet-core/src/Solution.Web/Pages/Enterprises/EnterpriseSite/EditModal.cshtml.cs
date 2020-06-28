using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseSite.ViewModels;
using Volo.Abp.Application.Dtos;

namespace Solution.Web.Pages.Enterprises.EnterpriseSite
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEnterpriseSiteViewModel ViewModel { get; set; }

        private readonly IEnterpriseAppService _iEnterpriseAppService;

        public List<SelectListItem> EnterpriseList { get; set; }


        private readonly IEnterpriseSiteAppService _service;

        public EditModalModel(IEnterpriseSiteAppService service, IEnterpriseAppService iEnterpriseAppService)
        {
            _service = service;
            _iEnterpriseAppService = iEnterpriseAppService;
            var list = _iEnterpriseAppService.GetListAsync(
                new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto() { MaxResultCount = LimitedResultRequestDto.MaxMaxResultCount }).Result.Items;
            EnterpriseList = (from a in list
                              select new SelectListItem
                              {
                                  Value = a.Id.ToString(),
                                  Text = a.Name,
                              }).ToList();
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