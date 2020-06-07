using System.Threading.Tasks;

namespace Solution.Data
{
    public interface ISolutionDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
