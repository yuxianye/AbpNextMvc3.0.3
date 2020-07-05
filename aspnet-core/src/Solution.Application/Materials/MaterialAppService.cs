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
    public class MaterialAppService : CrudAppService<Material, MaterialDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMaterialDto, CreateUpdateMaterialDto>,
        IMaterialAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Materials.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Materials.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Materials.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Materials.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Materials.Delete;

        public MaterialAppService(IRepository<Material, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<MaterialDto> CreateAsync(CreateUpdateMaterialDto input)
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