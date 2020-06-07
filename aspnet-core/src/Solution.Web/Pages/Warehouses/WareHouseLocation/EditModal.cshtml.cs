using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WareHouseLocation.ViewModels;
namespace Solution.Web.Pages.Warehouses.WareHouseLocation
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditWareHouseLocationViewModel ViewModel { get; set; }

        private readonly IWareHouseLocationAppService _service;

        public EditModalModel(IWareHouseLocationAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<WareHouseLocationDto, CreateEditWareHouseLocationViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWareHouseLocationViewModel, CreateUpdateWareHouseLocationDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}