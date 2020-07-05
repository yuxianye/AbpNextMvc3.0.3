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
    public class BOMAppService : CrudAppService<BOM, BOMDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBOMDto, CreateUpdateBOMDto>,
        IBOMAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.BOMs.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.BOMs.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.BOMs.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.BOMs.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.BOMs.Delete;

        public BOMAppService(IRepository<BOM, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<BOMDto> CreateAsync(CreateUpdateBOMDto input)
        {
            await CheckCreatePolicyAsync();

            if (Repository.Any(a => a.Name == input.Name))
            {
                throw new UserFriendlyException(message: L["Error"], details: L["NameAlreadyExists", input.Name]);
            }


            if (Repository.Any(a => a.ProductId == input.ProductId && a.MaterialId==input.MaterialId && a.Version==input.Version))
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