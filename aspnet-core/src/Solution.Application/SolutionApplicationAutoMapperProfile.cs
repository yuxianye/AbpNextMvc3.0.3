using AutoMapper;
using Solution.Enterprises;
using Solution.Enterprises.Dtos;
using Solution.Equipments;
using Solution.Equipments.Dtos;
using Solution.Materials;
using Solution.Materials.Dtos;
using Solution.Public;
using Solution.Public.Dtos;
using Solution.Qualities;
using Solution.Qualities.Dtos;
using Solution.Suppliers;
using Solution.Suppliers.Dtos;
using Solution.Warehouses;
using Solution.Warehouses.Dtos;
namespace Solution
{
    public class SolutionApplicationAutoMapperProfile : Profile
    {
        public SolutionApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Enterprise, EnterpriseDto>();
            CreateMap<CreateUpdateEnterpriseDto, Enterprise>(MemberList.Source);
            CreateMap<EnterpriseArea, EnterpriseAreaDto>();
            CreateMap<CreateUpdateEnterpriseAreaDto, EnterpriseArea>(MemberList.Source);
            CreateMap<EnterpriseProductionLine, EnterpriseProductionLineDto>();
            CreateMap<CreateUpdateEnterpriseProductionLineDto, EnterpriseProductionLine>(MemberList.Source);
            CreateMap<EnterpriseSite, EnterpriseSiteDto>();
            CreateMap<CreateUpdateEnterpriseSiteDto, EnterpriseSite>(MemberList.Source);
            CreateMap<EnterpriseWorkCenter, EnterpriseWorkCenterDto>();
            CreateMap<CreateUpdateEnterpriseWorkCenterDto, EnterpriseWorkCenter>(MemberList.Source);
            CreateMap<EnterpriseWorkLocation, EnterpriseWorkLocationDto>();
            CreateMap<CreateUpdateEnterpriseWorkLocationDto, EnterpriseWorkLocation>(MemberList.Source);
            CreateMap<Equipment, EquipmentDto>();
            CreateMap<CreateUpdateEquipmentDto, Equipment>(MemberList.Source);
            CreateMap<EquipmentBrand, EquipmentBrandDto>();
            CreateMap<CreateUpdateEquipmentBrandDto, EquipmentBrand>(MemberList.Source);
            CreateMap<EquipmentInspection, EquipmentInspectionDto>();
            CreateMap<CreateUpdateEquipmentInspectionDto, EquipmentInspection>(MemberList.Source);
            CreateMap<EquipmentInspectionResult, EquipmentInspectionResultDto>();
            CreateMap<CreateUpdateEquipmentInspectionResultDto, EquipmentInspectionResult>(MemberList.Source);
            CreateMap<EquipmentMaintenance, EquipmentMaintenanceDto>();
            CreateMap<CreateUpdateEquipmentMaintenanceDto, EquipmentMaintenance>(MemberList.Source);
            CreateMap<EquipmentMaintenanceResult, EquipmentMaintenanceResultDto>();
            CreateMap<CreateUpdateEquipmentMaintenanceResultDto, EquipmentMaintenanceResult>(MemberList.Source);
            CreateMap<EquipmentSparePart, EquipmentSparePartDto>();
            CreateMap<CreateUpdateEquipmentSparePartDto, EquipmentSparePart>(MemberList.Source);
            CreateMap<EquipmentSparePartType, EquipmentSparePartTypeDto>();
            CreateMap<CreateUpdateEquipmentSparePartTypeDto, EquipmentSparePartType>(MemberList.Source);
            CreateMap<EquipmentStatus, EquipmentStatusDto>();
            CreateMap<CreateUpdateEquipmentStatusDto, EquipmentStatus>(MemberList.Source);
            CreateMap<EquipmentType, EquipmentTypeDto>();
            CreateMap<CreateUpdateEquipmentTypeDto, EquipmentType>(MemberList.Source);
            CreateMap<Material, MaterialDto>();
            CreateMap<CreateUpdateMaterialDto, Material>(MemberList.Source);
            CreateMap<Product, ProductDto>();
            CreateMap<CreateUpdateProductDto, Product>(MemberList.Source);
            CreateMap<ProductType, ProductTypeDto>();
            CreateMap<CreateUpdateProductTypeDto, ProductType>(MemberList.Source);
            CreateMap<BOM, BOMDto>();
            CreateMap<CreateUpdateBOMDto, BOM>(MemberList.Source);
            CreateMap<Unit, UnitDto>();
            CreateMap<CreateUpdateUnitDto, Unit>(MemberList.Source);
            CreateMap<QualityInspect, QualityInspectDto>();
            CreateMap<CreateUpdateQualityInspectDto, QualityInspect>(MemberList.Source);
            CreateMap<QualityInspectResult, QualityInspectResultDto>();
            CreateMap<CreateUpdateQualityInspectResultDto, QualityInspectResult>(MemberList.Source);
            CreateMap<QualityInspectType, QualityInspectTypeDto>();
            CreateMap<CreateUpdateQualityInspectTypeDto, QualityInspectType>(MemberList.Source);
            CreateMap<QualityProblemLib, QualityProblemLibDto>();
            CreateMap<CreateUpdateQualityProblemLibDto, QualityProblemLib>(MemberList.Source);
            CreateMap<SupplierLevel, SupplierLevelDto>();
            CreateMap<CreateUpdateSupplierLevelDto, SupplierLevel>(MemberList.Source);
            CreateMap<Warehouse, WarehouseDto>();
            CreateMap<CreateUpdateWarehouseDto, Warehouse>(MemberList.Source);
            CreateMap<WarehouseArea, WarehouseAreaDto>();
            CreateMap<CreateUpdateWarehouseAreaDto, WarehouseArea>(MemberList.Source);
            CreateMap<WareHouseLocation, WareHouseLocationDto>();
            CreateMap<CreateUpdateWareHouseLocationDto, WareHouseLocation>(MemberList.Source);
            CreateMap<WarehouseType, WarehouseTypeDto>();
            CreateMap<CreateUpdateWarehouseTypeDto, WarehouseType>(MemberList.Source);
            CreateMap<Suppliers.Suppliers, SuppliersDto>();
            CreateMap<CreateUpdateSuppliersDto, Suppliers.Suppliers>(MemberList.Source);
        }
    }
}
