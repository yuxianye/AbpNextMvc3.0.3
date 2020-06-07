using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentSparePartType.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentSparePartType
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEquipmentSparePartTypeViewModel ViewModel { get; set; }

        private readonly IEquipmentSparePartTypeAppService _service;

        public EditModalModel(IEquipmentSparePartTypeAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EquipmentSparePartTypeDto, CreateEditEquipmentSparePartTypeViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentSparePartTypeViewModel, CreateUpdateEquipmentSparePartTypeDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}