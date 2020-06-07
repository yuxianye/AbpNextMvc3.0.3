using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.Materials;
using Solution.Materials.Dtos;
using Solution.Web.Pages.Materials.ProductType.ViewModels;
namespace Solution.Web.Pages.Materials.ProductType
{
    public class CreateModalModel : SolutionPageModel
    {
        [BindProperty]
        public CreateEditProductTypeViewModel ViewModel { get; set; }

        private readonly IProductTypeAppService _service;

        public CreateModalModel(IProductTypeAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductTypeViewModel, CreateUpdateProductTypeDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}