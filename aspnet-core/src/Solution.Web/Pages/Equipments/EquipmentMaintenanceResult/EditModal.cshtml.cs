using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentMaintenanceResult.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentMaintenanceResult
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEquipmentMaintenanceResultViewModel ViewModel { get; set; }

        private readonly IEquipmentMaintenanceResultAppService _service;

        public EditModalModel(IEquipmentMaintenanceResultAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EquipmentMaintenanceResultDto, CreateEditEquipmentMaintenanceResultViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentMaintenanceResultViewModel, CreateUpdateEquipmentMaintenanceResultDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}