using System;
using Solution.Permissions;
using Solution.Materials.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

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
        }
    }
}