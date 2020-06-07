using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.Equipment.ViewModels;
namespace Solution.Web.Pages.Equipments.Equipment
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentViewModel ViewModel { get; set; }

        private readonly IEquipmentAppService _service;

        public CreateModalModel(IEquipmentAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentViewModel, CreateUpdateEquipmentDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}