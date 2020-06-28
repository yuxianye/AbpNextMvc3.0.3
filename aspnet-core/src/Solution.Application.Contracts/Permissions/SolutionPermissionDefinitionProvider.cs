using Solution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Solution.Permissions
{
    public class SolutionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SolutionPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SolutionPermissions.MyPermission1, L("Permission:MyPermission1"));


            var enterprisePermission = myGroup.AddPermission(SolutionPermissions.Enterprises.Default, L("Permission:Enterprises"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Create, L("Permission:Create"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Update, L("Permission:Update"));
            enterprisePermission.AddChild(SolutionPermissions.Enterprises.Delete, L("Permission:Delete"));

            var enterpriseAreaPermission = myGroup.AddPermission(SolutionPermissions.EnterpriseAreas.Default, L("Permission:EnterpriseAreas"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.EnterpriseAreas.Create, L("Permission:Create"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.EnterpriseAreas.Update, L("Permission:Update"));
            enterpriseAreaPermission.AddChild(SolutionPermissions.EnterpriseAreas.Delete, L("Permission:Delete"));

            var enterpriseProductionLinePermission = myGroup.AddPermission(SolutionPermissions.EnterpriseProductionLines.Default, L("Permission:EnterpriseProductionLines"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.EnterpriseProductionLines.Create, L("Permission:Create"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.EnterpriseProductionLines.Update, L("Permission:Update"));
            enterpriseProductionLinePermission.AddChild(SolutionPermissions.EnterpriseProductionLines.Delete, L("Permission:Delete"));

            var enterpriseSitePermission = myGroup.AddPermission(SolutionPermissions.EnterpriseSites.Default, L("Permission:EnterpriseSites"));
            enterpriseSitePermission.AddChild(SolutionPermissions.EnterpriseSites.Create, L("Permission:Create"));
            enterpriseSitePermission.AddChild(SolutionPermissions.EnterpriseSites.Update, L("Permission:Update"));
            enterpriseSitePermission.AddChild(SolutionPermissions.EnterpriseSites.Delete, L("Permission:Delete"));

            var enterpriseWorkCenterPermission = myGroup.AddPermission(SolutionPermissions.EnterpriseWorkCenters.Default, L("Permission:EnterpriseWorkCenters"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.EnterpriseWorkCenters.Create, L("Permission:Create"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.EnterpriseWorkCenters.Update, L("Permission:Update"));
            enterpriseWorkCenterPermission.AddChild(SolutionPermissions.EnterpriseWorkCenters.Delete, L("Permission:Delete"));

            var enterpriseWorkLocationPermission = myGroup.AddPermission(SolutionPermissions.EnterpriseWorkLocations.Default, L("Permission:EnterpriseWorkLocations"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.EnterpriseWorkLocations.Create, L("Permission:Create"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.EnterpriseWorkLocations.Update, L("Permission:Update"));
            enterpriseWorkLocationPermission.AddChild(SolutionPermissions.EnterpriseWorkLocations.Delete, L("Permission:Delete"));

            var equipmentPermission = myGroup.AddPermission(SolutionPermissions.Equipments.Default, L("Permission:Equipments"));
            equipmentPermission.AddChild(SolutionPermissions.Equipments.Create, L("Permission:Create"));
            equipmentPermission.AddChild(SolutionPermissions.Equipments.Update, L("Permission:Update"));
            equipmentPermission.AddChild(SolutionPermissions.Equipments.Delete, L("Permission:Delete"));

            var equipmentBrandPermission = myGroup.AddPermission(SolutionPermissions.EquipmentBrands.Default, L("Permission:EquipmentBrands"));
            equipmentBrandPermission.AddChild(SolutionPermissions.EquipmentBrands.Create, L("Permission:Create"));
            equipmentBrandPermission.AddChild(SolutionPermissions.EquipmentBrands.Update, L("Permission:Update"));
            equipmentBrandPermission.AddChild(SolutionPermissions.EquipmentBrands.Delete, L("Permission:Delete"));

            var equipmentInspectionPermission = myGroup.AddPermission(SolutionPermissions.EquipmentInspections.Default, L("Permission:EquipmentInspections"));
            equipmentInspectionPermission.AddChild(SolutionPermissions.EquipmentInspections.Create, L("Permission:Create"));
            equipmentInspectionPermission.AddChild(SolutionPermissions.EquipmentInspections.Update, L("Permission:Update"));
            equipmentInspectionPermission.AddChild(SolutionPermissions.EquipmentInspections.Delete, L("Permission:Delete"));

            var equipmentInspectionResultPermission = myGroup.AddPermission(SolutionPermissions.EquipmentInspectionResults.Default, L("Permission:EquipmentInspectionResults"));
            equipmentInspectionResultPermission.AddChild(SolutionPermissions.EquipmentInspectionResults.Create, L("Permission:Create"));
            equipmentInspectionResultPermission.AddChild(SolutionPermissions.EquipmentInspectionResults.Update, L("Permission:Update"));
            equipmentInspectionResultPermission.AddChild(SolutionPermissions.EquipmentInspectionResults.Delete, L("Permission:Delete"));

            var equipmentMaintenancePermission = myGroup.AddPermission(SolutionPermissions.EquipmentMaintenances.Default, L("Permission:EquipmentMaintenances"));
            equipmentMaintenancePermission.AddChild(SolutionPermissions.EquipmentMaintenances.Create, L("Permission:Create"));
            equipmentMaintenancePermission.AddChild(SolutionPermissions.EquipmentMaintenances.Update, L("Permission:Update"));
            equipmentMaintenancePermission.AddChild(SolutionPermissions.EquipmentMaintenances.Delete, L("Permission:Delete"));

            var equipmentMaintenanceResultPermission = myGroup.AddPermission(SolutionPermissions.EquipmentMaintenanceResults.Default, L("Permission:EquipmentMaintenanceResults"));
            equipmentMaintenanceResultPermission.AddChild(SolutionPermissions.EquipmentMaintenanceResults.Create, L("Permission:Create"));
            equipmentMaintenanceResultPermission.AddChild(SolutionPermissions.EquipmentMaintenanceResults.Update, L("Permission:Update"));
            equipmentMaintenanceResultPermission.AddChild(SolutionPermissions.EquipmentMaintenanceResults.Delete, L("Permission:Delete"));

            var equipmentSparePartPermission = myGroup.AddPermission(SolutionPermissions.EquipmentSpareParts.Default, L("Permission:EquipmentSpareParts"));
            equipmentSparePartPermission.AddChild(SolutionPermissions.EquipmentSpareParts.Create, L("Permission:Create"));
            equipmentSparePartPermission.AddChild(SolutionPermissions.EquipmentSpareParts.Update, L("Permission:Update"));
            equipmentSparePartPermission.AddChild(SolutionPermissions.EquipmentSpareParts.Delete, L("Permission:Delete"));

            var equipmentSparePartTypePermission = myGroup.AddPermission(SolutionPermissions.EquipmentSparePartTypes.Default, L("Permission:EquipmentSparePartTypes"));
            equipmentSparePartTypePermission.AddChild(SolutionPermissions.EquipmentSparePartTypes.Create, L("Permission:Create"));
            equipmentSparePartTypePermission.AddChild(SolutionPermissions.EquipmentSparePartTypes.Update, L("Permission:Update"));
            equipmentSparePartTypePermission.AddChild(SolutionPermissions.EquipmentSparePartTypes.Delete, L("Permission:Delete"));

            var equipmentStatusPermission = myGroup.AddPermission(SolutionPermissions.EquipmentStatus.Default, L("Permission:EquipmentStatus"));
            equipmentStatusPermission.AddChild(SolutionPermissions.EquipmentStatus.Create, L("Permission:Create"));
            equipmentStatusPermission.AddChild(SolutionPermissions.EquipmentStatus.Update, L("Permission:Update"));
            equipmentStatusPermission.AddChild(SolutionPermissions.EquipmentStatus.Delete, L("Permission:Delete"));

            var equipmentTypePermission = myGroup.AddPermission(SolutionPermissions.EquipmentTypes.Default, L("Permission:EquipmentTypes"));
            equipmentTypePermission.AddChild(SolutionPermissions.EquipmentTypes.Create, L("Permission:Create"));
            equipmentTypePermission.AddChild(SolutionPermissions.EquipmentTypes.Update, L("Permission:Update"));
            equipmentTypePermission.AddChild(SolutionPermissions.EquipmentTypes.Delete, L("Permission:Delete"));

            var materialPermission = myGroup.AddPermission(SolutionPermissions.Materials.Default, L("Permission:Materials"));
            materialPermission.AddChild(SolutionPermissions.Materials.Create, L("Permission:Create"));
            materialPermission.AddChild(SolutionPermissions.Materials.Update, L("Permission:Update"));
            materialPermission.AddChild(SolutionPermissions.Materials.Delete, L("Permission:Delete"));

            var productPermission = myGroup.AddPermission(SolutionPermissions.Products.Default, L("Permission:Products"));
            productPermission.AddChild(SolutionPermissions.Products.Create, L("Permission:Create"));
            productPermission.AddChild(SolutionPermissions.Products.Update, L("Permission:Update"));
            productPermission.AddChild(SolutionPermissions.Products.Delete, L("Permission:Delete"));

            var productTypePermission = myGroup.AddPermission(SolutionPermissions.ProductTypes.Default, L("Permission:ProductTypes"));
            productTypePermission.AddChild(SolutionPermissions.ProductTypes.Create, L("Permission:Create"));
            productTypePermission.AddChild(SolutionPermissions.ProductTypes.Update, L("Permission:Update"));
            productTypePermission.AddChild(SolutionPermissions.ProductTypes.Delete, L("Permission:Delete"));

            var bOMPermission = myGroup.AddPermission(SolutionPermissions.BOMs.Default, L("Permission:Materials"));
            bOMPermission.AddChild(SolutionPermissions.BOMs.Create, L("Permission:Create"));
            bOMPermission.AddChild(SolutionPermissions.BOMs.Update, L("Permission:Update"));
            bOMPermission.AddChild(SolutionPermissions.BOMs.Delete, L("Permission:Delete"));

            var unitPermission = myGroup.AddPermission(SolutionPermissions.Units.Default, L("Permission:Public"));
            unitPermission.AddChild(SolutionPermissions.Units.Create, L("Permission:Create"));
            unitPermission.AddChild(SolutionPermissions.Units.Update, L("Permission:Update"));
            unitPermission.AddChild(SolutionPermissions.Units.Delete, L("Permission:Delete"));

            var qualityInspectPermission = myGroup.AddPermission(SolutionPermissions.QualityInspects.Default, L("Permission:QualityInspects"));
            qualityInspectPermission.AddChild(SolutionPermissions.QualityInspects.Create, L("Permission:Create"));
            qualityInspectPermission.AddChild(SolutionPermissions.QualityInspects.Update, L("Permission:Update"));
            qualityInspectPermission.AddChild(SolutionPermissions.QualityInspects.Delete, L("Permission:Delete"));

            var qualityInspectResultPermission = myGroup.AddPermission(SolutionPermissions.QualityInspectResults.Default, L("Permission:QualityInspectResults"));
            qualityInspectResultPermission.AddChild(SolutionPermissions.QualityInspectResults.Create, L("Permission:Create"));
            qualityInspectResultPermission.AddChild(SolutionPermissions.QualityInspectResults.Update, L("Permission:Update"));
            qualityInspectResultPermission.AddChild(SolutionPermissions.QualityInspectResults.Delete, L("Permission:Delete"));

            var qualityInspectTypePermission = myGroup.AddPermission(SolutionPermissions.QualityInspectTypes.Default, L("Permission:QualityInspectTypes"));
            qualityInspectTypePermission.AddChild(SolutionPermissions.QualityInspectTypes.Create, L("Permission:Create"));
            qualityInspectTypePermission.AddChild(SolutionPermissions.QualityInspectTypes.Update, L("Permission:Update"));
            qualityInspectTypePermission.AddChild(SolutionPermissions.QualityInspectTypes.Delete, L("Permission:Delete"));

            var qualityProblemLibPermission = myGroup.AddPermission(SolutionPermissions.QualityProblemLibs.Default, L("Permission:QualityProblemLibs"));
            qualityProblemLibPermission.AddChild(SolutionPermissions.QualityProblemLibs.Create, L("Permission:Create"));
            qualityProblemLibPermission.AddChild(SolutionPermissions.QualityProblemLibs.Update, L("Permission:Update"));
            qualityProblemLibPermission.AddChild(SolutionPermissions.QualityProblemLibs.Delete, L("Permission:Delete"));

            var suppliersPermission = myGroup.AddPermission(SolutionPermissions.Suppliers.Default, L("Permission:Suppliers"));
            suppliersPermission.AddChild(SolutionPermissions.Suppliers.Create, L("Permission:Create"));
            suppliersPermission.AddChild(SolutionPermissions.Suppliers.Update, L("Permission:Update"));
            suppliersPermission.AddChild(SolutionPermissions.Suppliers.Delete, L("Permission:Delete"));

            var supplierLevelPermission = myGroup.AddPermission(SolutionPermissions.SupplierLevels.Default, L("Permission:SupplierLevels"));
            supplierLevelPermission.AddChild(SolutionPermissions.SupplierLevels.Create, L("Permission:Create"));
            supplierLevelPermission.AddChild(SolutionPermissions.SupplierLevels.Update, L("Permission:Update"));
            supplierLevelPermission.AddChild(SolutionPermissions.SupplierLevels.Delete, L("Permission:Delete"));

            var warehousePermission = myGroup.AddPermission(SolutionPermissions.Warehouses.Default, L("Permission:Warehouses"));
            warehousePermission.AddChild(SolutionPermissions.Warehouses.Create, L("Permission:Create"));
            warehousePermission.AddChild(SolutionPermissions.Warehouses.Update, L("Permission:Update"));
            warehousePermission.AddChild(SolutionPermissions.Warehouses.Delete, L("Permission:Delete"));

            var warehouseAreaPermission = myGroup.AddPermission(SolutionPermissions.WarehouseAreas.Default, L("Permission:WarehouseAreas"));
            warehouseAreaPermission.AddChild(SolutionPermissions.WarehouseAreas.Create, L("Permission:Create"));
            warehouseAreaPermission.AddChild(SolutionPermissions.WarehouseAreas.Update, L("Permission:Update"));
            warehouseAreaPermission.AddChild(SolutionPermissions.WarehouseAreas.Delete, L("Permission:Delete"));

            var WarehouseLocationPermission = myGroup.AddPermission(SolutionPermissions.WarehouseLocations.Default, L("Permission:WarehouseLocations"));
            WarehouseLocationPermission.AddChild(SolutionPermissions.WarehouseLocations.Create, L("Permission:Create"));
            WarehouseLocationPermission.AddChild(SolutionPermissions.WarehouseLocations.Update, L("Permission:Update"));
            WarehouseLocationPermission.AddChild(SolutionPermissions.WarehouseLocations.Delete, L("Permission:Delete"));

            var warehouseTypePermission = myGroup.AddPermission(SolutionPermissions.WarehouseTypes.Default, L("Permission:WarehouseTypes"));
            warehouseTypePermission.AddChild(SolutionPermissions.WarehouseTypes.Create, L("Permission:Create"));
            warehouseTypePermission.AddChild(SolutionPermissions.WarehouseTypes.Update, L("Permission:Update"));
            warehouseTypePermission.AddChild(SolutionPermissions.WarehouseTypes.Delete, L("Permission:Delete"));


            var customerPermission = myGroup.AddPermission(SolutionPermissions.Customers.Default, L("Permission:Customers"));
            customerPermission.AddChild(SolutionPermissions.Customers.Create, L("Permission:Create"));
            customerPermission.AddChild(SolutionPermissions.Customers.Update, L("Permission:Update"));
            customerPermission.AddChild(SolutionPermissions.Customers.Delete, L("Permission:Delete"));

            var orderStatusPermission = myGroup.AddPermission(SolutionPermissions.Orders.Default, L("Permission:Orders"));
            orderStatusPermission.AddChild(SolutionPermissions.Orders.Create, L("Permission:Create"));
            orderStatusPermission.AddChild(SolutionPermissions.Orders.Update, L("Permission:Update"));
            orderStatusPermission.AddChild(SolutionPermissions.Orders.Delete, L("Permission:Delete"));

            var orderPermission = myGroup.AddPermission(SolutionPermissions.OrderStatus.Default, L("Permission:OrderStatus"));
            orderPermission.AddChild(SolutionPermissions.OrderStatus.Create, L("Permission:Create"));
            orderPermission.AddChild(SolutionPermissions.OrderStatus.Update, L("Permission:Update"));
            orderPermission.AddChild(SolutionPermissions.OrderStatus.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SolutionResource>(name);
        }
    }
}
