using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Materials;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.ProductType.ViewModels;
namespace Solution.Web.Pages.Materials.ProductType
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditProductTypeViewModel ViewModel { get; set; }

        private readonly IProductTypeAppService _service;

        public EditModalModel(IProductTypeAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<ProductTypeDto, CreateEditProductTypeViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductTypeViewModel, CreateUpdateProductTypeDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}