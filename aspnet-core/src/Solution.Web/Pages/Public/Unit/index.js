$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.public.unit;
    var createModal = new abp.ModalManager(abp.appPath + 'Public/Unit/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Public/Unit/EditModal');

    var dataTable = $('#UnitTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.Units.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.Units.Delete'),
                                confirmMessage: function (data) {
                                    return l('UnitDeletionConfirmationMessage', data.record.id);
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

    $('#NewUnitButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});