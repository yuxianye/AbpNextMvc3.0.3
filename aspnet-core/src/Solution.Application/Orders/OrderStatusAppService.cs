using System;
using Solution.Permissions;
using Solution.Orders.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Solution.Localization;
using System.Linq;
using Volo.Abp;
using System.Threading.Tasks;

namespace Solution.Orders
{
    public class OrderStatusAppService : CrudAppService<OrderStatus, OrderStatusDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderStatusDto, CreateUpdateOrderStatusDto>,
        IOrderStatusAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.OrderStatus.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.OrderStatus.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.OrderStatus.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.OrderStatus.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.OrderStatus.Delete;

        public OrderStatusAppService(IRepository<OrderStatus, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<OrderStatusDto> CreateAsync(CreateUpdateOrderStatusDto input)
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