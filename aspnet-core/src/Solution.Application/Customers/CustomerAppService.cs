using System;
using Solution.Permissions;
using Solution.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;
using Solution.Localization;

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
    }
}