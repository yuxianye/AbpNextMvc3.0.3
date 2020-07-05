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

        private readonly IRepository<Solution.Equipments.EquipmentInspectionResult, Guid> _equipmentInspectionResultRepository;
        private readonly IRepository<Solution.Equipments.EquipmentMaintenanceResult, Guid> _equipmentMaintenanceResultRepository;
        private readonly IRepository<Suppliers.SupplierLevel, Guid> _supplierLevelRepository;
        private readonly IRepository<Suppliers.Suppliers, Guid> _suppliersRepository;


        private readonly IRepository<Public.Unit> _unitRepository;


        public SolutionDataSeedContributor(
            IGuidGenerator guidGenerator,
            IAsyncQueryableExecuter queryableExecuter,
            IRepository<Solution.Enterprises.Enterprise, Guid> enterpriseRepository,
            IRepository<Solution.Orders.OrderStatus, Guid> orderStatusRepository,
            IRepository<Solution.Equipments.EquipmentInspectionResult, Guid> equipmentInspectionResultRepository,
            IRepository<Solution.Equipments.EquipmentMaintenanceResult, Guid> equipmentMaintenanceResultRepository,
            IRepository<Suppliers.SupplierLevel, Guid> supplierLevelRepository,
            IRepository<Suppliers.Suppliers, Guid> suppliersRepository,
            IRepository<Public.Unit> unitRepository
            )
        {
            _guidGenerator = guidGenerator;
            _queryableExecuter = queryableExecuter;
            _enterpriseRepository = enterpriseRepository;
            _orderStatusRepository = orderStatusRepository;
            _equipmentInspectionResultRepository = equipmentInspectionResultRepository;
            _equipmentMaintenanceResultRepository = equipmentMaintenanceResultRepository;
            _supplierLevelRepository = supplierLevelRepository;
            _suppliersRepository = suppliersRepository;
            _unitRepository= unitRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _queryableExecuter.CountAsync(_enterpriseRepository) < 1)
            {
                for (int i = 1; i < 200; i++)
                {
                    await _enterpriseRepository.InsertAsync(
                        new Enterprises.Enterprise(_guidGenerator.Create(), $"新密第{i}耐火厂", $"新密市嵩山大道{i}号", "13800138000", $"测试数据{i}"));
                }
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

            if (await _queryableExecuter.CountAsync(_equipmentInspectionResultRepository) < 1)
            {
                await _equipmentInspectionResultRepository.InsertAsync(new Equipments.EquipmentInspectionResult(_guidGenerator.Create(), "正常", null));
                await _equipmentInspectionResultRepository.InsertAsync(new Equipments.EquipmentInspectionResult(_guidGenerator.Create(), "异常", null));
                await _equipmentInspectionResultRepository.InsertAsync(new Equipments.EquipmentInspectionResult(_guidGenerator.Create(), "异常不影响生产", null));
                await _equipmentInspectionResultRepository.InsertAsync(new Equipments.EquipmentInspectionResult(_guidGenerator.Create(), "待检查", null));
            }


            if (await _queryableExecuter.CountAsync(_equipmentMaintenanceResultRepository) < 1)
            {
                await _equipmentMaintenanceResultRepository.InsertAsync(new Equipments.EquipmentMaintenanceResult(_guidGenerator.Create(), "待维修", null));
                await _equipmentMaintenanceResultRepository.InsertAsync(new Equipments.EquipmentMaintenanceResult(_guidGenerator.Create(), "维修完成待观察", null));
                await _equipmentMaintenanceResultRepository.InsertAsync(new Equipments.EquipmentMaintenanceResult(_guidGenerator.Create(), "维修完成", null));
                await _equipmentMaintenanceResultRepository.InsertAsync(new Equipments.EquipmentMaintenanceResult(_guidGenerator.Create(), "已正常", null));
            }


            if (await _queryableExecuter.CountAsync(_supplierLevelRepository) < 1)
            {
                await _supplierLevelRepository.InsertAsync(new Suppliers.SupplierLevel(_guidGenerator.Create(), "一级", null));
                await _supplierLevelRepository.InsertAsync(new Suppliers.SupplierLevel(_guidGenerator.Create(), "二级", null));
                await _supplierLevelRepository.InsertAsync(new Suppliers.SupplierLevel(_guidGenerator.Create(), "三级", null));
                await _supplierLevelRepository.InsertAsync(new Suppliers.SupplierLevel(_guidGenerator.Create(), "四级", null));
                await _supplierLevelRepository.InsertAsync(new Suppliers.SupplierLevel(_guidGenerator.Create(), "五级", null));
           }

            if (await _queryableExecuter.CountAsync(_unitRepository) < 1)
            {
                await _unitRepository.InsertAsync(new Public.Unit(_guidGenerator.Create(), "吨", null));
                await _unitRepository.InsertAsync(new Public.Unit(_guidGenerator.Create(), "箱", null));
                await _unitRepository.InsertAsync(new Public.Unit(_guidGenerator.Create(), "米", null));
                await _unitRepository.InsertAsync(new Public.Unit(_guidGenerator.Create(), "千克", null));
      
            }
            


        }
    }
}
