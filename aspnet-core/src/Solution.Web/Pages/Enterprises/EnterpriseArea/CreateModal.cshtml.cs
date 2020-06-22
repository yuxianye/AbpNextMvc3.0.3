using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Web.Pages.Enterprises.EnterpriseArea.ViewModels;
using Volo.Abp.Guids;

namespace Solution.Web.Pages.Enterprises.EnterpriseArea
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEnterpriseAreaViewModel ViewModel { get; set; }

        private readonly IEnterpriseAreaAppService _service;
        private readonly IEnterpriseAreaAppService _iEnterpriseAreaAppService;
        private readonly IGuidGenerator _iGuidGenerator;

       // public List<SelectListItem> EnterpriseSiteList { get; set; }

        public List<SelectListItem> EnterpriseSiteList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi1"},
            new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi2"},
            new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi3"},
            new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi4"},
            new SelectListItem (){  Value=Guid.NewGuid ().ToString (), Text="ceshi5"},
        };

        public CreateModalModel(IEnterpriseAreaAppService service, IGuidGenerator guidGenerator, IEnterpriseAreaAppService enterpriseAreaAppService)
        {
            _service = service;
            _iEnterpriseAreaAppService = enterpriseAreaAppService;
            _iGuidGenerator = guidGenerator;
            //ViewModel.EnterpriseSiteId
            var list = _iEnterpriseAreaAppService.GetListAsync(new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto())
                .Result.Items;

            //EnterpriseSiteList = (from a in list
            //                      select new SelectListItem
            //                      {
            //                          Value = a.Id.ToString(),
            //                          Text = a.Name
            //                      }).ToList();
        }




        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEnterpriseAreaViewModel, CreateUpdateEnterpriseAreaDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}