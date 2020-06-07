using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentSparePart.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentSparePart
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentSparePartViewModel ViewModel { get; set; }

        private readonly IEquipmentSparePartAppService _service;

        public CreateModalModel(IEquipmentSparePartAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentSparePartViewModel, CreateUpdateEquipmentSparePartDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}