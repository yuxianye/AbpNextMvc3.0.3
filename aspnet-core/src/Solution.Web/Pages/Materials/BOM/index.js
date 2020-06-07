$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.materials.bOM;
    var createModal = new abp.ModalManager(abp.appPath + 'Materials/BOM/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Materials/BOM/EditModal');

    var dataTable = $('#BOMTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.BOMs.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.BOMs.Delete'),
                                confirmMessage: function (data) {
                                    return l('BOMDeletionConfirmationMessage', data.record.id);
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
            { data: "productId" },
            { data: "version" },
            { data: "materialId" },
            { data: "count" },
            { data: "isEnabled" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBOMButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});