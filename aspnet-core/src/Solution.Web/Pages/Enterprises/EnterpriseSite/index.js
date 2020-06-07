$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.enterprises.enterpriseSite;
    var createModal = new abp.ModalManager(abp.appPath + 'Enterprises/EnterpriseSite/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Enterprises/EnterpriseSite/EditModal');

    var dataTable = $('#EnterpriseSiteTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.EnterpriseSites.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.EnterpriseSites.Delete'),
                                confirmMessage: function (data) {
                                    return l('EnterpriseSiteDeletionConfirmationMessage', data.record.id);
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
            { data: "enterpriseId" },
            { data: "name" },
            { data: "address" },
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

    $('#NewEnterpriseSiteButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});