using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentBrand.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentBrand
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditEquipmentBrandViewModel ViewModel { get; set; }

        private readonly IEquipmentBrandAppService _service;

        public CreateModalModel(IEquipmentBrandAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentBrandViewModel, CreateUpdateEquipmentBrandDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}