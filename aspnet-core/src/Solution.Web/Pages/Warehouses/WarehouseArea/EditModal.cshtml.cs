using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
using Solution.Web.Pages.Warehouses.WarehouseArea.ViewModels;
namespace Solution.Web.Pages.Warehouses.WarehouseArea
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditWarehouseAreaViewModel ViewModel { get; set; }

        private readonly IWarehouseAreaAppService _service;

        public EditModalModel(IWarehouseAreaAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<WarehouseAreaDto, CreateEditWarehouseAreaViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWarehouseAreaViewModel, CreateUpdateWarehouseAreaDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}