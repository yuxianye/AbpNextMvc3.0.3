using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Suppliers;
using Solution.Suppliers.Dtos;
using Solution.Web.Pages.Suppliers.SupplierLevel.ViewModels;
namespace Solution.Web.Pages.Suppliers.SupplierLevel
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditSupplierLevelViewModel ViewModel { get; set; }

        private readonly ISupplierLevelAppService _service;

        public EditModalModel(ISupplierLevelAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<SupplierLevelDto, CreateEditSupplierLevelViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditSupplierLevelViewModel, CreateUpdateSupplierLevelDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}