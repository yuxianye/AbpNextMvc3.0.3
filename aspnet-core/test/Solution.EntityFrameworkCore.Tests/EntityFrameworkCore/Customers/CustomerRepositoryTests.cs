using System;
using System.Threading.Tasks;
using Solution.Customers;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Customers
{
    public class CustomerRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Customer, Guid> _customerRepository;

        public CustomerRepositoryTests()
        {
            _customerRepository = GetRequiredService<IRepository<Customer, Guid>>();
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
