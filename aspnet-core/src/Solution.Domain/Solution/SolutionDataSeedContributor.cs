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

        public SolutionDataSeedContributor(
             IGuidGenerator guidGenerator,
        IRepository<Solution.Enterprises.Enterprise, Guid> enterpriseRepository,
            IAsyncQueryableExecuter queryableExecuter)
        {
            _guidGenerator = guidGenerator;
            _queryableExecuter = queryableExecuter;
            _enterpriseRepository = enterpriseRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _queryableExecuter.CountAsync(_enterpriseRepository) < 1)
            {
                await _enterpriseRepository.InsertAsync(
                    new Enterprises.Enterprise(_guidGenerator.Create(), "方信新材料", "新密市", "13800138000", "测试数据"));
            }




        }











    }
}
