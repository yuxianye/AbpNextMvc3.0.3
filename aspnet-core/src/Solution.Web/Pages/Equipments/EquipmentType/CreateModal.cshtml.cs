using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentType.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentType
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentTypeViewModel ViewModel { get; set; }

        private readonly IEquipmentTypeAppService _service;

        public CreateModalModel(IEquipmentTypeAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentTypeViewModel, CreateUpdateEquipmentTypeDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}