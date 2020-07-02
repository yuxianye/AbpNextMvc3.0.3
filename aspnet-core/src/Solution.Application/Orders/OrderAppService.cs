using System;
using Solution.Permissions;
using Solution.Orders.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Solution.Localization;

namespace Solution.Orders
{
    public class OrderAppService : CrudAppService<Order, OrderDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderDto, CreateUpdateOrderDto>,
        IOrderAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Orders.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Orders.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Orders.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Orders.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Orders.Delete;

        public OrderAppService(IRepository<Order, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }
    }
}