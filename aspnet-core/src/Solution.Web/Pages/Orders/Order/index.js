$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.orders.order;
    var createModal = new abp.ModalManager(abp.appPath + 'Orders/Order/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Orders/Order/EditModal');

    var dataTable = $('#OrderTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.Orders.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.Orders.Delete'),
                                confirmMessage: function (data) {
                                    return l('OrderDeletionConfirmationMessage', data.record.id);
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
            { data: "customerId" },
            { data: "productId" },
            { data: "count" },
            { data: "orderStatusID" },
            { data: "orderDate" },
            { data: "deliveryDate" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewOrderButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});