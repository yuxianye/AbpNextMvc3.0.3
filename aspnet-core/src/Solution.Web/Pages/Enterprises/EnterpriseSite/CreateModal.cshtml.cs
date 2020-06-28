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
using Volo.Abp.Guids;

namespace Solution.Web.Pages.Enterprises.EnterpriseSite
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseSiteViewModel ViewModel { get; set; }

        private readonly IEnterpriseSiteAppService _service;
        private readonly IEnterpriseAppService _iEnterpriseAppService;

        public List<SelectListItem> EnterpriseList { get; set; }

        public CreateModalModel(IEnterpriseSiteAppService service, IEnterpriseAppService enterpriseAppService)
        {
            _service = service;
            _iEnterpriseAppService = enterpriseAppService;

            var list = _iEnterpriseAppService.GetListAsync(
                new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto() { MaxResultCount = LimitedResultRequestDto.MaxMaxResultCount }).Result.Items;
            EnterpriseList = (from a in list
                              select new SelectListItem
                              {
                                  Value = a.Id.ToString(),
                                  Text = a.Name,
                              }).ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseSiteViewModel, CreateUpdateEnterpriseSiteDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}