using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Solution.Data
{
    /* This is used if database provider does't define
     * ISolutionDbSchemaMigrator implementation.
     */
    public class NullSolutionDbSchemaMigrator : ISolutionDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}