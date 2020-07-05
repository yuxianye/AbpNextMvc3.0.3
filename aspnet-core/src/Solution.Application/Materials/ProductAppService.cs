using System;
using Solution.Permissions;
using Solution.Materials.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Solution.Localization;
using System.Threading.Tasks;
using System.Linq;
using Volo.Abp;

namespace Solution.Materials
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto, CreateUpdateProductDto>,
        IProductAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Products.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Products.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Products.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Products.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Products.Delete;

        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<ProductDto> CreateAsync(CreateUpdateProductDto input)
        {
            await CheckCreatePolicyAsync();


            if (Repository.Any(a => a.Code == input.Code))
            {
                throw new UserFriendlyException(message: L["Error"], details: L["CodeAlreadyExists", input.Name]);
            }

            if (Repository.Any(a => a.Name == input.Name))
            {
                throw new UserFriendlyException(message: L["Error"], details: L["NameAlreadyExists", input.Name]);
            }

            var entity = MapToEntity(input);

            TryToSetTenantId(entity);

            await Repository.InsertAsync(entity, autoSave: true);

            return MapToGetOutputDto(entity);
        }
    }
}