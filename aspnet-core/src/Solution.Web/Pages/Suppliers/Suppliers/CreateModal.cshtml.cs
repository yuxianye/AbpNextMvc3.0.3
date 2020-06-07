using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Suppliers;
using Solution.Suppliers.Dtos;
using Solution.Web.Pages.Suppliers.Suppliers.ViewModels;
namespace Solution.Web.Pages.Suppliers.Suppliers
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditSuppliersViewModel ViewModel { get; set; }

        private readonly ISuppliersAppService _service;

        public CreateModalModel(ISuppliersAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditSuppliersViewModel, CreateUpdateSuppliersDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}