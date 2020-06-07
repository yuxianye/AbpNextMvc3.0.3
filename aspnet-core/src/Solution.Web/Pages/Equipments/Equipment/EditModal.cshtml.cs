using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.Equipment.ViewModels;
namespace Solution.Web.Pages.Equipments.Equipment
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEquipmentViewModel ViewModel { get; set; }

        private readonly IEquipmentAppService _service;

        public EditModalModel(IEquipmentAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EquipmentDto, CreateEditEquipmentViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentViewModel, CreateUpdateEquipmentDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}