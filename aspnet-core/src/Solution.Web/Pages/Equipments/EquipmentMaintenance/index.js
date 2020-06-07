$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.equipments.equipmentMaintenance;
    var createModal = new abp.ModalManager(abp.appPath + 'Equipments/EquipmentMaintenance/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Equipments/EquipmentMaintenance/EditModal');

    var dataTable = $('#EquipmentMaintenanceTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('Solution.EquipmentMaintenances.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.EquipmentMaintenances.Delete'),
                                confirmMessage: function (data) {
                                    return l('EquipmentMaintenanceDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "equipmentId" },
            { data: "problem" },
            { data: "cause" },
            { data: "solution" },
            { data: "actualStartTime" },
            { data: "actualFinishTime" },
            { data: "consumable" },
            { data: "responsiblePerson" },
            { data: "maintenanceTime" },
            { data: "equipmentMaintenanceResultId" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEquipmentMaintenanceButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});