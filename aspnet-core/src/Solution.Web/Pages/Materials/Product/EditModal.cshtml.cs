using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Materials;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.Product.ViewModels;
namespace Solution.Web.Pages.Materials.Product
{
    public class EditModalModel : SolutionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditProductViewModel ViewModel { get; set; }

        private readonly IProductAppService _service;

        public EditModalModel(IProductAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<ProductDto, CreateEditProductViewModel>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}