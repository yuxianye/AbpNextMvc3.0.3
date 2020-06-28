using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;
using System.Linq;
using Volo.Abp.Linq;
using Microsoft.EntityFrameworkCore;

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

        public override async Task<PagedResultDto<EnterpriseSiteDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            await CheckGetListPolicyAsync();

            var query = CreateFilteredQuery(input);

            var totalCount = await AsyncQueryableExecuter.CountAsync(query);
         
            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);
            query = query.Include(a => a.Enterprise);
            var entities = await AsyncQueryableExecuter.ToListAsync(query);

            return new PagedResultDto<EnterpriseSiteDto>(
                totalCount,
                entities.Select(MapToGetListOutputDto).ToList()
            );
        }
    }
}