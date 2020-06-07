$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.equipments.equipmentInspection;
    var createModal = new abp.ModalManager(abp.appPath + 'Equipments/EquipmentInspection/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Equipments/EquipmentInspection/EditModal');

    var dataTable = $('#EquipmentInspectionTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.EquipmentInspections.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.EquipmentInspections.Delete'),
                                confirmMessage: function (data) {
                                    return l('EquipmentInspectionDeletionConfirmationMessage', data.record.id);
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
            { data: "inspectPerson" },
            { data: "inspectionTime" },
            { data: "equipmentInspectionResultId" },
            { data: "problem" },
            { data: "cause" },
            { data: "solution" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEquipmentInspectionButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});