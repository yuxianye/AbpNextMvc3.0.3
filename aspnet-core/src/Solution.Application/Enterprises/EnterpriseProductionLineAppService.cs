using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

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
        }
    }
}