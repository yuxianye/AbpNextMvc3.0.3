using System;
using System.Linq;
using System.Threading.Tasks;
using Solution.Localization;
using Solution.Permissions;
using Solution.Qualities.Dtos;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Qualities
{
    public class QualityInspectResultAppService : CrudAppService<QualityInspectResult, QualityInspectResultDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateQualityInspectResultDto, CreateUpdateQualityInspectResultDto>,
        IQualityInspectResultAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.QualityInspectResults.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.QualityInspectResults.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.QualityInspectResults.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.QualityInspectResults.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.QualityInspectResults.Delete;

        public QualityInspectResultAppService(IRepository<QualityInspectResult, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<QualityInspectResultDto> CreateAsync(CreateUpdateQualityInspectResultDto input)
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