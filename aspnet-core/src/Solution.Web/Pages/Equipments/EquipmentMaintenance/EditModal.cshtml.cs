using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentMaintenance.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentMaintenance
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEquipmentMaintenanceViewModel ViewModel { get; set; }

        private readonly IEquipmentMaintenanceAppService _service;

        public EditModalModel(IEquipmentMaintenanceAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EquipmentMaintenanceDto, CreateEditEquipmentMaintenanceViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentMaintenanceViewModel, CreateUpdateEquipmentMaintenanceDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}