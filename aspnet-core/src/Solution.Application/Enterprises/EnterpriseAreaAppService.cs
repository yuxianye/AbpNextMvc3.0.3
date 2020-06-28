using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Solution.Enterprises
{
    public class EnterpriseAreaAppService : CrudAppService<EnterpriseArea, EnterpriseAreaDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEnterpriseAreaDto, CreateUpdateEnterpriseAreaDto>,
        IEnterpriseAreaAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Delete;

        public EnterpriseAreaAppService(IRepository<EnterpriseArea, Guid> repository) : base(repository)
        {
        }

        public override async Task<PagedResultDto<EnterpriseAreaDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            await CheckGetListPolicyAsync();

            var query = CreateFilteredQuery(input);

            var totalCount = await AsyncQueryableExecuter.CountAsync(query);

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);
            query = query.Include(a => a.EnterpriseSite);
            var entities = await AsyncQueryableExecuter.ToListAsync(query);

            return new PagedResultDto<EnterpriseAreaDto>(
                totalCount,
                entities.Select(MapToGetListOutputDto).ToList()
            );
        }
    }
}