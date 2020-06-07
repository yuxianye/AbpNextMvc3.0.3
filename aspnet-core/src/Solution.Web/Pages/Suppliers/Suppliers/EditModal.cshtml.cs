using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Suppliers;
using Solution.Suppliers.Dtos;
using Solution.Web.Pages.Suppliers.Suppliers.ViewModels;
namespace Solution.Web.Pages.Suppliers.Suppliers
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditSuppliersViewModel ViewModel { get; set; }

        private readonly ISuppliersAppService _service;

        public EditModalModel(ISuppliersAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<SuppliersDto, CreateEditSuppliersViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditSuppliersViewModel, CreateUpdateSuppliersDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}