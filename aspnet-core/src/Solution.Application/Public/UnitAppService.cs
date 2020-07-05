using System;
using System.Linq;
using System.Threading.Tasks;
using Solution.Localization;
using Solution.Permissions;
using Solution.Public.Dtos;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Public
{
    public class UnitAppService : CrudAppService<Unit, UnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUnitDto, CreateUpdateUnitDto>,
        IUnitAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Units.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Units.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Units.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Units.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Units.Delete;

        public UnitAppService(IRepository<Unit, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<UnitDto> CreateAsync(CreateUpdateUnitDto input)
        {
            await CheckCreatePolicyAsync();

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