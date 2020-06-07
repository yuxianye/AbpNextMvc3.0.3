$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.warehouses.warehouse;
    var createModal = new abp.ModalManager(abp.appPath + 'Warehouses/Warehouse/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Warehouses/Warehouse/EditModal');

    var dataTable = $('#WarehouseTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.Warehouses.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.Warehouses.Delete'),
                                confirmMessage: function (data) {
                                    return l('WarehouseDeletionConfirmationMessage', data.record.id);
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
            { data: "enterpriseAreaId" },
            { data: "name" },
            { data: "manager" },
            { data: "phone" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewWarehouseButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});