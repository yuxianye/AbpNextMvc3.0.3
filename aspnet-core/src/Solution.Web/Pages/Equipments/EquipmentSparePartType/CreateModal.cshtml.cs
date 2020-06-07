using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentSparePartType.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentSparePartType
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentSparePartTypeViewModel ViewModel { get; set; }

        private readonly IEquipmentSparePartTypeAppService _service;

        public CreateModalModel(IEquipmentSparePartTypeAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentSparePartTypeViewModel, CreateUpdateEquipmentSparePartTypeDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}