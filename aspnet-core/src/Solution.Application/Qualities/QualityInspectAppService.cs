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
    public class QualityInspectAppService : CrudAppService<QualityInspect, QualityInspectDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateQualityInspectDto, CreateUpdateQualityInspectDto>,
        IQualityInspectAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.QualityInspects.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.QualityInspects.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.QualityInspects.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.QualityInspects.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.QualityInspects.Delete;

        public QualityInspectAppService(IRepository<QualityInspect, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<QualityInspectDto> CreateAsync(CreateUpdateQualityInspectDto input)
        {
            await CheckCreatePolicyAsync();

            if (Repository.Any(a => a.Code == input.Code))
            {
                throw new UserFriendlyException(message: L["Error"], details: L["CodeAlreadyExists", input.Code]);
            }

            var entity = MapToEntity(input);

            TryToSetTenantId(entity);

            await Repository.InsertAsync(entity, autoSave: true);

            return MapToGetOutputDto(entity);
        }
    }
}