using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Solution.Localization;
using System.Threading.Tasks;
using Volo.Abp;
using System.Linq;

namespace Solution.Enterprises
{
    public class EnterpriseWorkLocationAppService : CrudAppService<EnterpriseWorkLocation, EnterpriseWorkLocationDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEnterpriseWorkLocationDto, CreateUpdateEnterpriseWorkLocationDto>,
        IEnterpriseWorkLocationAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Delete;

        public EnterpriseWorkLocationAppService(IRepository<EnterpriseWorkLocation, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<EnterpriseWorkLocationDto> CreateAsync(CreateUpdateEnterpriseWorkLocationDto input)
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