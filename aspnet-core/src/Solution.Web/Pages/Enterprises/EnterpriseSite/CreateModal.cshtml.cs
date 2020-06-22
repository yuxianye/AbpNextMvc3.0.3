using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseSite.ViewModels;
using Volo.Abp.Guids;

namespace Solution.Web.Pages.Enterprises.EnterpriseSite
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseSiteViewModel ViewModel { get; set; }

        private readonly IEnterpriseSiteAppService _service;
        private readonly IEnterpriseAppService _iEnterpriseAppService;
        private readonly IGuidGenerator _iGuidGenerator;

        public List<SelectListItem> EnterpriseList { get; set; }

        //public List<SelectListItem> EnterpriseSiteList { get; set; } = new List<SelectListItem>
        //{
        //    new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi1"},
        //    new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi2"},
        //    new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi3"},
        //    new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi4"},
        //    new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi5"},
        //};


        public CreateModalModel(IEnterpriseSiteAppService service, IEnterpriseAppService enterpriseAppService)
        {
            _service = service;
            _iEnterpriseAppService = enterpriseAppService;

            var list = _iEnterpriseAppService.GetListAsync(new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto()).Result.Items;
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