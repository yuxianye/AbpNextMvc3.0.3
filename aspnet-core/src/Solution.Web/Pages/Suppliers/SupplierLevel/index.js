$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.suppliers.supplierLevel;
    var createModal = new abp.ModalManager(abp.appPath + 'Suppliers/SupplierLevel/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Suppliers/SupplierLevel/EditModal');

    var dataTable = $('#SupplierLevelTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.SupplierLevels.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.SupplierLevels.Delete'),
                                confirmMessage: function (data) {
                                    return l('SupplierLevelDeletionConfirmationMessage', data.record.id);
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

    $('#NewSupplierLevelButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});