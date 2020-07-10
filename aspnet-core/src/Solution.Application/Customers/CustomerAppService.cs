using System;
using Solution.Permissions;
using Solution.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;
using Solution.Localization;
using Volo.Abp;
using System.Linq;

namespace Solution.Customers
{
    public class CustomerAppService : CrudAppService<Customer, CustomerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerDto, CreateUpdateCustomerDto>,
        ICustomerAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Customers.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Customers.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Customers.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Customers.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Customers.Delete;

        public CustomerAppService(IRepository<Customer, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }



        public override Task<PagedResultDto<CustomerDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return base.GetListAsync(input);
        }

        public override async Task<CustomerDto> CreateAsync(CreateUpdateCustomerDto input)
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

        public override async Task<CustomerDto> UpdateAsync(Guid id, CreateUpdateCustomerDto input)
        {

            await CheckUpdatePolicyAsync();

            var entity = await GetEntityByIdAsync(id);
            //TODO: Check if input has id different than given id and normalize if it's default value, throw ex otherwise
            var count = Repository.Count(a => a.Name == input.Name && entity.Id != id);
            //if (Repository.Any (a=>a.Name == input.Name && entity.Id != id))

            if (count > 0)
            {
                throw new UserFriendlyException(message: L["Error"], details: L["NameAlreadyExists", input.Name]);
            }

            MapToEntity(input, entity);
            await Repository.UpdateAsync(entity, autoSave: true);

            return MapToGetOutputDto(entity);

        }





    }
}