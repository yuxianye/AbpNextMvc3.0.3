using System;
using System.Threading.Tasks;
using Solution.Orders;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Orders
{
    public class OrderStatusRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<OrderStatus, Guid> _orderStatusRepository;

        public OrderStatusRepositoryTests()
        {
            _orderStatusRepository = GetRequiredService<IRepository<OrderStatus, Guid>>();
        }

        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
    }
}
