using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Web.Pages.Equipments.EquipmentInspectionResult.ViewModels;
namespace Solution.Web.Pages.Equipments.EquipmentInspectionResult
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditEquipmentInspectionResultViewModel ViewModel { get; set; }

        private readonly IEquipmentInspectionResultAppService _service;

        public EditModalModel(IEquipmentInspectionResultAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<EquipmentInspectionResultDto, CreateEditEquipmentInspectionResultViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditEquipmentInspectionResultViewModel, CreateUpdateEquipmentInspectionResultDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}