using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Suppliers;
using Solution.Suppliers.Dtos;
using Solution.Web.Pages.Suppliers.SupplierLevel.ViewModels;
namespace Solution.Web.Pages.Suppliers.SupplierLevel
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditSupplierLevelViewModel ViewModel { get; set; }

        private readonly ISupplierLevelAppService _service;

        public CreateModalModel(ISupplierLevelAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditSupplierLevelViewModel, CreateUpdateSupplierLevelDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}