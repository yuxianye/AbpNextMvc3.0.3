$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.equipments.equipment;
    var createModal = new abp.ModalManager(abp.appPath + 'Equipments/Equipment/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Equipments/Equipment/EditModal');

    var dataTable = $('#EquipmentTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.Equipments.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.Equipments.Delete'),
                                confirmMessage: function (data) {
                                    return l('EquipmentDeletionConfirmationMessage', data.record.id);
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
            { data: "equipmentTypeId" },
            { data: "equipmentBrandId" },
            { data: "code" },
            { data: "name" },
            { data: "specification" },
            { data: "manufactureDate" },
            { data: "equipmentStatusId" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEquipmentButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});