using System;
using System.Linq;
using System.Threading.Tasks;
using Solution.Localization;
using Solution.Permissions;
using Solution.Suppliers.Dtos;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Suppliers
{
    public class SuppliersAppService : CrudAppService<Suppliers, SuppliersDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSuppliersDto, CreateUpdateSuppliersDto>,
        ISuppliersAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Suppliers.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Suppliers.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Suppliers.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Suppliers.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Suppliers.Delete;

        public SuppliersAppService(IRepository<Suppliers, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<SuppliersDto> CreateAsync(CreateUpdateSuppliersDto input)
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