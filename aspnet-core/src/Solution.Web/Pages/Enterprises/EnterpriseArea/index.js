$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.enterprises.enterpriseArea;
    var createModal = new abp.ModalManager(abp.appPath + 'Enterprises/EnterpriseArea/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Enterprises/EnterpriseArea/EditModal');

    var dataTable = $('#EnterpriseAreaTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.EnterpriseAreas.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.EnterpriseAreas.Delete'),
                                confirmMessage: function (data) {
                                    return l('EnterpriseAreaDeletionConfirmationMessage', data.record.id);
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
            { data: "enterpriseSiteId" },
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

    $('#NewEnterpriseAreaButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});