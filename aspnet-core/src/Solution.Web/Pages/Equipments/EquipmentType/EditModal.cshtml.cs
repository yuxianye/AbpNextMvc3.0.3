using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentType.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentType
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEquipmentTypeViewModel ViewModel { get; set; }

        private readonly IEquipmentTypeAppService _service;

        public EditModalModel(IEquipmentTypeAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EquipmentTypeDto, CreateEditEquipmentTypeViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentTypeViewModel, CreateUpdateEquipmentTypeDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}