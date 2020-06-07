$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.enterprises.enterpriseWorkCenter;
    var createModal = new abp.ModalManager(abp.appPath + 'Enterprises/EnterpriseWorkCenter/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Enterprises/EnterpriseWorkCenter/EditModal');

    var dataTable = $('#EnterpriseWorkCenterTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.EnterpriseWorkCenters.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.EnterpriseWorkCenters.Delete'),
                                confirmMessage: function (data) {
                                    return l('EnterpriseWorkCenterDeletionConfirmationMessage', data.record.id);
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
            { data: "enterpriseProductionLineId" },
            { data: "name" },
            { data: "manager" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEnterpriseWorkCenterButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});