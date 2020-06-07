using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentInspectionResult.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentInspectionResult
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentInspectionResultViewModel ViewModel { get; set; }

        private readonly IEquipmentInspectionResultAppService _service;

        public CreateModalModel(IEquipmentInspectionResultAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentInspectionResultViewModel, CreateUpdateEquipmentInspectionResultDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}