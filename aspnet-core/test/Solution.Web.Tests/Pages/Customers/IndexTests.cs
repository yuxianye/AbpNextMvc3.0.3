
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Solution.Pages.Customers
{
    public class Index_Tests : SolutionWebTestBase
    {
        [Fact]
        public async Task Index_Page_Test()
        {
            // Arrange

            // Act
            var response = await GetResponseAsStringAsync("/Customer");

            // Assert
            response.ShouldNotBeNull();
        }
    }
}
