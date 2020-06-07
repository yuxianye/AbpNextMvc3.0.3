using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentMaintenanceResult.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentMaintenanceResult
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentMaintenanceResultViewModel ViewModel { get; set; }

        private readonly IEquipmentMaintenanceResultAppService _service;

        public CreateModalModel(IEquipmentMaintenanceResultAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentMaintenanceResultViewModel, CreateUpdateEquipmentMaintenanceResultDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}