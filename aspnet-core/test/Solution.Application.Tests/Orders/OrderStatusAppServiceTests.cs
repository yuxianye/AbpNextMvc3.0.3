using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Orders
{
    public class OrderStatusAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IOrderStatusAppService _orderStatusAppService;

        public OrderStatusAppServiceTests()
        {
            _orderStatusAppService = GetRequiredService<IOrderStatusAppService>();
        }

        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
