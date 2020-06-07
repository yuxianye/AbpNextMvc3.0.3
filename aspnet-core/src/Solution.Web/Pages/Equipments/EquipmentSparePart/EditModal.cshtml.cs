using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentSparePart.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentSparePart
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEquipmentSparePartViewModel ViewModel { get; set; }

        private readonly IEquipmentSparePartAppService _service;

        public EditModalModel(IEquipmentSparePartAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EquipmentSparePartDto, CreateEditEquipmentSparePartViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentSparePartViewModel, CreateUpdateEquipmentSparePartDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}