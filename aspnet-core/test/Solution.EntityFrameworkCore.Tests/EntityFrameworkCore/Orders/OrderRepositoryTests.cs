using System;
using System.Threading.Tasks;
using Solution.Orders;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Orders
{
    public class OrderRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Order, Guid> _orderRepository;

        public OrderRepositoryTests()
        {
            _orderRepository = GetRequiredService<IRepository<Order, Guid>>();
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
