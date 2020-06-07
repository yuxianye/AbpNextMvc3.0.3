using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentInspection.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentInspection
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentInspectionViewModel ViewModel { get; set; }

        private readonly IEquipmentInspectionAppService _service;

        public CreateModalModel(IEquipmentInspectionAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentInspectionViewModel, CreateUpdateEquipmentInspectionDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}