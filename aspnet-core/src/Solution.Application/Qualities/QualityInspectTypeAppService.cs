using System;
using Solution.Permissions;
using Solution.Qualities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Qualities
{
    public class QualityInspectTypeAppService : CrudAppService<QualityInspectType, QualityInspectTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateQualityInspectTypeDto, CreateUpdateQualityInspectTypeDto>,
        IQualityInspectTypeAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.QualityInspectTypes.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.QualityInspectTypes.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.QualityInspectTypes.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.QualityInspectTypes.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.QualityInspectTypes.Delete;

        public QualityInspectTypeAppService(IRepository<QualityInspectType, Guid> repository) : base(repository)
        {
        }
    }
}