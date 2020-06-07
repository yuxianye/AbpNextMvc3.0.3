using System;
using Solution.Permissions;
using Solution.Qualities.Dtos;
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
        }
    }
}