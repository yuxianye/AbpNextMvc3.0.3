$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.suppliers.suppliers;
    var createModal = new abp.ModalManager(abp.appPath + 'Suppliers/Suppliers/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Suppliers/Suppliers/EditModal');

    var dataTable = $('#SuppliersTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.Suppliers.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.Suppliers.Delete'),
                                confirmMessage: function (data) {
                                    return l('SuppliersDeletionConfirmationMessage', data.record.id);
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
            { data: "code" },
            { data: "name" },
            { data: "supplierLevelId" },
            { data: "contact" },
            { data: "phone" },
            { data: "fax" },
            { data: "address" },
            { data: "email" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewSuppliersButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});