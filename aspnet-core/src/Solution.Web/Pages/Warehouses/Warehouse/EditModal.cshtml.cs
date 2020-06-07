using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.Warehouse.ViewModels;
namespace Solution.Web.Pages.Warehouses.Warehouse
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditWarehouseViewModel ViewModel { get; set; }

        private readonly IWarehouseAppService _service;

        public EditModalModel(IWarehouseAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<WarehouseDto, CreateEditWarehouseViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWarehouseViewModel, CreateUpdateWarehouseDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}