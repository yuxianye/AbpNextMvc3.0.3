using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.Linq;
using System.Reflection;

namespace Solution
{
    public class SolutionDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private readonly IAsyncQueryableExecuter _queryableExecuter;

        private readonly IRepository<Solution.Enterprises.Enterprise, Guid> _enterpriseRepository;
        private readonly IRepository<Solution.Orders.OrderStatus, Guid> _orderStatusRepository;

        public SolutionDataSeedContributor(
             IGuidGenerator guidGenerator,
            IAsyncQueryableExecuter queryableExecuter,
        IRepository<Solution.Enterprises.Enterprise, Guid> enterpriseRepository,
      IRepository<Solution.Orders.OrderStatus, Guid> orderStatusRepository
            )
        {
            _guidGenerator = guidGenerator;
            _queryableExecuter = queryableExecuter;
            _enterpriseRepository = enterpriseRepository;
            _orderStatusRepository = orderStatusRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _queryableExecuter.CountAsync(_enterpriseRepository) < 1)
            {
                await _enterpriseRepository.InsertAsync(
                    new Enterprises.Enterprise(_guidGenerator.Create(), "方信新材料", "新密市", "13800138000", "测试数据"));
            }


            if (await _queryableExecuter.CountAsync(_orderStatusRepository) < 1)
            {
                await _orderStatusRepository.InsertAsync(new Orders.OrderStatus(_guidGenerator.Create(), "新建", null));
                await _orderStatusRepository.InsertAsync(new Orders.OrderStatus(_guidGenerator.Create(), "已排产", null));
                await _orderStatusRepository.InsertAsync(new Orders.OrderStatus(_guidGenerator.Create(), "生产中", null));
                await _orderStatusRepository.InsertAsync(new Orders.OrderStatus(_guidGenerator.Create(), "生产完", null));
                await _orderStatusRepository.InsertAsync(new Orders.OrderStatus(_guidGenerator.Create(), "待发货", null));
                await _orderStatusRepository.InsertAsync(new Orders.OrderStatus(_guidGenerator.Create(), "撤销", null));
            }

        }











    }
}
