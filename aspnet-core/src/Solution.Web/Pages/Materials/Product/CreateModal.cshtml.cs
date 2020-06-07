using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Materials;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.Product.ViewModels;
namespace Solution.Web.Pages.Materials.Product
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditProductViewModel ViewModel { get; set; }

        private readonly IProductAppService _service;

        public CreateModalModel(IProductAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}