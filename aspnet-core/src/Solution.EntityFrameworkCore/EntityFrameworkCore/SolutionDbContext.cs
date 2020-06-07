using Microsoft.EntityFrameworkCore;
using Solution.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using Solution.Enterprises;
using Solution.Equipments;
using Solution.Materials;
using Solution.Public;
using Solution.Qualities;
using Solution.Suppliers;
using Solution.Warehouses;

namespace Solution.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See SolutionMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class SolutionDbContext : AbpDbContext<SolutionDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside SolutionDbContextModelCreatingExtensions.ConfigureSolution
         */
        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<EnterpriseArea> EnterpriseAreas { get; set; }
        public DbSet<EnterpriseProductionLine> EnterpriseProductionLines { get; set; }
        public DbSet<EnterpriseSite> EnterpriseSites { get; set; }
        public DbSet<EnterpriseWorkCenter> EnterpriseWorkCenters { get; set; }
        public DbSet<EnterpriseWorkLocation> EnterpriseWorkLocations { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<EquipmentBrand> EquipmentBrands { get; set; }
        public DbSet<EquipmentInspection> EquipmentInspections { get; set; }
        public DbSet<EquipmentInspectionResult> EquipmentInspectionResults { get; set; }
        public DbSet<EquipmentMaintenance> EquipmentMaintenances { get; set; }
        public DbSet<EquipmentMaintenanceResult> EquipmentMaintenanceResults { get; set; }
        public DbSet<EquipmentSparePart> EquipmentSpareParts { get; set; }
        public DbSet<EquipmentSparePartType> EquipmentSparePartTypes { get; set; }
        public DbSet<EquipmentStatus> EquipmentStatuses { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<BOM> BOMs { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<QualityInspect> QualityInspects { get; set; }
        public DbSet<QualityInspectResult> QualityInspectResults { get; set; }
        public DbSet<QualityInspectType> QualityInspectTypes { get; set; }
        public DbSet<QualityProblemLib> QualityProblemLibs { get; set; }
        public DbSet<SupplierLevel> SupplierLevels { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseArea> WarehouseAreas { get; set; }
        public DbSet<WareHouseLocation> WareHouseLocations { get; set; }
        public DbSet<WarehouseType> WarehouseTypes { get; set; }
        public DbSet<Suppliers.Suppliers> Suppliers { get; set; }

        public SolutionDbContext(DbContextOptions<SolutionDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the SolutionEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureSolution method */

            builder.ConfigureSolution();
        }
    }
}
