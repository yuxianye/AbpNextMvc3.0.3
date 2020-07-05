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
    public class QualityProblemLibAppService : CrudAppService<QualityProblemLib, QualityProblemLibDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateQualityProblemLibDto, CreateUpdateQualityProblemLibDto>,
        IQualityProblemLibAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.QualityProblemLibs.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.QualityProblemLibs.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.QualityProblemLibs.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.QualityProblemLibs.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.QualityProblemLibs.Delete;

        public QualityProblemLibAppService(IRepository<QualityProblemLib, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<QualityProblemLibDto> CreateAsync(CreateUpdateQualityProblemLibDto input)
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