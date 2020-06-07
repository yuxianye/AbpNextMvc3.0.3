using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentMaintenance.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentMaintenance
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentMaintenanceViewModel ViewModel { get; set; }

        private readonly IEquipmentMaintenanceAppService _service;

        public CreateModalModel(IEquipmentMaintenanceAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentMaintenanceViewModel, CreateUpdateEquipmentMaintenanceDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}