using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;

namespace Solution.Enterprises
{

    public class EnterpriseAppService : CrudAppService<Enterprise, EnterpriseDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEnterpriseDto, CreateUpdateEnterpriseDto>,
        IEnterpriseAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Enterprises.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Enterprises.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Enterprises.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Enterprises.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Enterprises.Delete;

        public EnterpriseAppService(IRepository<Enterprise, Guid> repository) : base(repository)
        {
        }
       
    }
}