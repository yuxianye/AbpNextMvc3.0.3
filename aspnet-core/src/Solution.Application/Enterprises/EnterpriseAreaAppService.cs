using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Solution.Localization;
using Volo.Abp;

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
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<PagedResultDto<EnterpriseAreaDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            await CheckGetListPolicyAsync();

            var query = CreateFilteredQuery(input);

            var totalCount = await AsyncExecuter.CountAsync(query);

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);
            query = query.Include(a => a.EnterpriseSite);
            var entities = await AsyncExecuter.ToListAsync(query);

            return new PagedResultDto<EnterpriseAreaDto>(
                totalCount,
                entities.Select(MapToGetListOutputDto).ToList()
            );
        }

        public override async Task<EnterpriseAreaDto> CreateAsync(CreateUpdateEnterpriseAreaDto input)
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