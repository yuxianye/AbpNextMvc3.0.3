$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.warehouses.WarehouseLocation;
    var createModal = new abp.ModalManager(abp.appPath + 'Warehouses/WarehouseLocation/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Warehouses/WarehouseLocation/EditModal');

    var dataTable = $('#WarehouseLocationTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.WarehouseLocations.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.WarehouseLocations.Delete'),
                                confirmMessage: function (data) {
                                    return l('WarehouseLocationDeletionConfirmationMessage', data.record.id);
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
            { data: "wareHouseAreaId" },
            { data: "code" },
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

    $('#NewWarehouseLocationButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});