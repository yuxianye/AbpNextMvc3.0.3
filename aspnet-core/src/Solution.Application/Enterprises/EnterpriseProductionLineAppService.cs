using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Solution.Localization;
using Volo.Abp;
using System.Threading.Tasks;
using System.Linq;

namespace Solution.Enterprises
{
    public class EnterpriseProductionLineAppService : CrudAppService<EnterpriseProductionLine, EnterpriseProductionLineDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEnterpriseProductionLineDto, CreateUpdateEnterpriseProductionLineDto>,
        IEnterpriseProductionLineAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EnterpriseProductionLines.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EnterpriseProductionLines.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EnterpriseProductionLines.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EnterpriseProductionLines.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EnterpriseProductionLines.Delete;

        public EnterpriseProductionLineAppService(IRepository<EnterpriseProductionLine, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<EnterpriseProductionLineDto> CreateAsync(CreateUpdateEnterpriseProductionLineDto input)
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