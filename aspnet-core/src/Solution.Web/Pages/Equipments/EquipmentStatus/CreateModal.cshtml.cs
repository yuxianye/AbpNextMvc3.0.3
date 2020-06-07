using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentStatus.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentStatus
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentStatusViewModel ViewModel { get; set; }

        private readonly IEquipmentStatusAppService _service;

        public CreateModalModel(IEquipmentStatusAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentStatusViewModel, CreateUpdateEquipmentStatusDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}