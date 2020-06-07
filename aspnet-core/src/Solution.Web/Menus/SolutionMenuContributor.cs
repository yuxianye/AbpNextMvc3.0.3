using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Solution.Localization;
using Solution.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;
using Solution.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace Solution.Web.Menus
{
    public class SolutionMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var authorizationService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<SolutionResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Solution.Home", l["Menu:Home"], "~/"));

            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Enterprises.Default))
            {
                var enterpriseMenu = new ApplicationMenuItem("Enterprises", l["Menu:Enterprises"]);
                context.Menu.AddItem(enterpriseMenu);

                enterpriseMenu.AddItem(new ApplicationMenuItem("Enterprises", l["Menu:Enterprises"], "/Enterprises/Enterprise"));
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseSites.Default))
                {
                    enterpriseMenu.AddItem(
                        new ApplicationMenuItem("EnterpriseSites", l["Menu:EnterpriseSites"], "/Enterprises/EnterpriseSite")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseAreas.Default))
                {
                    enterpriseMenu.AddItem(
                        new ApplicationMenuItem("EnterpriseAreas", l["Menu:EnterpriseAreas"], "/Enterprises/EnterpriseArea")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseProductionLines.Default))
                {
                    enterpriseMenu.AddItem(
                        new ApplicationMenuItem("EnterpriseProductionLines", l["Menu:EnterpriseProductionLines"], "/Enterprises/EnterpriseProductionLine")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseWorkCenters.Default))
                {
                    enterpriseMenu.AddItem(
                        new ApplicationMenuItem("EnterpriseWorkCenters", l["Menu:EnterpriseWorkCenters"], "/Enterprises/EnterpriseWorkCenter")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EnterpriseWorkLocations.Default))
                {
                    enterpriseMenu.AddItem(
                        new ApplicationMenuItem("EnterpriseWorkLocations", l["Menu:EnterpriseWorkLocations"], "/Enterprises/EnterpriseWorkLocation")
                    );
                }
            }

            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Equipments.Default))
            {

                var equipmentMenu = new ApplicationMenuItem("Equipments", l["Menu:Equipments"]);
                context.Menu.AddItem(equipmentMenu);

                equipmentMenu.AddItem(new ApplicationMenuItem("Equipments", l["Menu:Equipments"], "/Equipments/Equipment"));

                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentBrands.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentBrands", l["Menu:EquipmentBrands"], "/Equipments/EquipmentBrand")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentInspections.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentInspections", l["Menu:EquipmentInspections"], "/Equipments/EquipmentInspection")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentInspectionResults.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentInspectionResults", l["Menu:EquipmentInspectionResults"], "/Equipments/EquipmentInspectionResult")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentMaintenances.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentMaintenances", l["Menu:EquipmentMaintenances"], "/Equipments/EquipmentMaintenance")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentMaintenanceResults.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentMaintenanceResults", l["Menu:EquipmentMaintenanceResults"], "/Equipments/EquipmentMaintenanceResult")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentSpareParts.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentSpareParts", l["Menu:EquipmentSpareParts"], "/Equipments/EquipmentSparePart")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentSparePartTypes.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentSparePartTypes", l["Menu:EquipmentSparePartTypes"], "/Equipments/EquipmentSparePartType")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentStatus.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentStatus", l["Menu:EquipmentStatus"], "/Equipments/EquipmentStatus")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.EquipmentTypes.Default))
                {
                    equipmentMenu.AddItem(
                        new ApplicationMenuItem("EquipmentTypes", l["Menu:EquipmentTypes"], "/Equipments/EquipmentType")
                    );
                }
            }

            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Materials.Default))
            {
                var materialMenu = new ApplicationMenuItem("Materials", l["Menu:Materials"]);
                context.Menu.AddItem(materialMenu);
                materialMenu.AddItem(new ApplicationMenuItem("Materials", l["Menu:Materials"], "/Materials/Material"));

                if (await authorizationService.IsGrantedAsync(SolutionPermissions.Products.Default))
                {
                    materialMenu.AddItem(
                        new ApplicationMenuItem("Products", l["Menu:Products"], "/Materials/Product")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.ProductTypes.Default))
                {
                    materialMenu.AddItem(
                        new ApplicationMenuItem("ProductTypes", l["Menu:ProductTypes"], "/Materials/ProductType")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.BOMs.Default))
                {
                    materialMenu.AddItem(
                        new ApplicationMenuItem("BOMs", l["Menu:BOMs"], "/Materials/BOM")
                    );
                }
            }


            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Units.Default))
            {
                var baseMenu = new ApplicationMenuItem("BaseData", l["Menu:BaseData"]);
                context.Menu.AddItem(baseMenu);

                baseMenu.AddItem(
                    new ApplicationMenuItem("Units", l["Menu:Units"], "/Public/Unit")
                );

            }


            if (await authorizationService.IsGrantedAsync(SolutionPermissions.QualityInspects.Default))
            {
                var qualityMenu = new ApplicationMenuItem("QualityInspects", l["Menu:QualityInspects"]);
                context.Menu.AddItem(qualityMenu);
                qualityMenu.AddItem(new ApplicationMenuItem("QualityInspects", l["Menu:QualityInspects"], "/Qualities/QualityInspect"));

                if (await authorizationService.IsGrantedAsync(SolutionPermissions.QualityInspectResults.Default))
                {
                    qualityMenu.AddItem(
                        new ApplicationMenuItem("QualityInspectResults", l["Menu:QualityInspectResults"], "/Qualities/QualityInspectResult")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.QualityInspectTypes.Default))
                {
                    qualityMenu.AddItem(
                        new ApplicationMenuItem("QualityInspectTypes", l["Menu:QualityInspectTypes"], "/Qualities/QualityInspectType")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.QualityProblemLibs.Default))
                {
                    qualityMenu.AddItem(
                        new ApplicationMenuItem("QualityProblemLibs", l["Menu:QualityProblemLibs"], "/Qualities/QualityProblemLib")
                    );
                }


            }

            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Suppliers.Default))
            {
                var supplierMenu = new ApplicationMenuItem("Suppliers", l["Menu:Suppliers"]);
                context.Menu.AddItem(supplierMenu);
                supplierMenu.AddItem(new ApplicationMenuItem("Suppliers", l["Menu:Suppliers"], "/Suppliers/Suppliers"));

                if (await authorizationService.IsGrantedAsync(SolutionPermissions.SupplierLevels.Default))
                {
                    supplierMenu.AddItem(
                        new ApplicationMenuItem("SupplierLevels", l["Menu:SupplierLevels"], "/Suppliers/SupplierLevel")
                    );
                }
            }


            if (await authorizationService.IsGrantedAsync(SolutionPermissions.Warehouses.Default))
            {
                var warehouseMenu = new ApplicationMenuItem("Warehouses", l["Menu:Warehouses"]);

                context.Menu.AddItem(warehouseMenu);
                warehouseMenu.AddItem(new ApplicationMenuItem("Warehouses", l["Menu:Warehouses"], "/Warehouses/Warehouse"));

                if (await authorizationService.IsGrantedAsync(SolutionPermissions.WarehouseAreas.Default))
                {
                    warehouseMenu.AddItem(
                        new ApplicationMenuItem("WarehouseAreas", l["Menu:WarehouseAreas"], "/Warehouses/WarehouseArea")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.WareHouseLocations.Default))
                {
                    warehouseMenu.AddItem(
                        new ApplicationMenuItem("WareHouseLocations", l["Menu:WareHouseLocations"], "/Warehouses/WareHouseLocation")
                    );
                }
                if (await authorizationService.IsGrantedAsync(SolutionPermissions.WarehouseTypes.Default))
                {
                    warehouseMenu.AddItem(
                        new ApplicationMenuItem("WarehouseTypes", l["Menu:WarehouseTypes"], "/Warehouses/WarehouseType")
                    );
                }
            }
        }
    }
}
