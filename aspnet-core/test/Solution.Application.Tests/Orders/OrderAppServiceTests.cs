using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Solution.Orders
{
    public class OrderAppServiceTests : SolutionApplicationTestBase
    {
        private readonly IOrderAppService _orderAppService;

        public OrderAppServiceTests()
        {
            _orderAppService = GetRequiredService<IOrderAppService>();
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
