$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.equipments.equipmentMaintenanceResult;
    var createModal = new abp.ModalManager(abp.appPath + 'Equipments/EquipmentMaintenanceResult/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Equipments/EquipmentMaintenanceResult/EditModal');

    var dataTable = $('#EquipmentMaintenanceResultTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.EquipmentMaintenanceResults.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.EquipmentMaintenanceResults.Delete'),
                                confirmMessage: function (data) {
                                    return l('EquipmentMaintenanceResultDeletionConfirmationMessage', data.record.id);
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
            { data: "name" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEquipmentMaintenanceResultButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});