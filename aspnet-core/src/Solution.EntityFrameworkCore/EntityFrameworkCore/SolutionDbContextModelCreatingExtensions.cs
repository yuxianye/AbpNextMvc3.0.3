using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Solution.EntityFrameworkCore
{
    public static class SolutionDbContextModelCreatingExtensions
    {
        public static void ConfigureSolution(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SolutionConsts.DbTablePrefix + "YourEntities", SolutionConsts.DbSchema);

            //    //...
            //});
        }
    }
}