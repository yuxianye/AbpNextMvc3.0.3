using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;

namespace Solution.Enterprises
{
    public class EnterpriseSiteAppService : CrudAppService<EnterpriseSite, EnterpriseSiteDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEnterpriseSiteDto, CreateUpdateEnterpriseSiteDto>,
        IEnterpriseSiteAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EnterpriseSites.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EnterpriseSites.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EnterpriseSites.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EnterpriseSites.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EnterpriseSites.Delete;

        public EnterpriseSiteAppService(IRepository<EnterpriseSite, Guid> repository) : base(repository)
        {
        }




        public override Task<PagedResultDto<EnterpriseSiteDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            



            return base.GetListAsync(input);
        }
    }
}