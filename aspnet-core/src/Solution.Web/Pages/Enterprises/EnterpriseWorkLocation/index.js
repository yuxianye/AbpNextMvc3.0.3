$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.enterprises.enterpriseWorkLocation;
    var createModal = new abp.ModalManager(abp.appPath + 'Enterprises/EnterpriseWorkLocation/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Enterprises/EnterpriseWorkLocation/EditModal');

    var dataTable = $('#EnterpriseWorkLocationTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.EnterpriseWorkLocations.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.EnterpriseWorkLocations.Delete'),
                                confirmMessage: function (data) {
                                    return l('EnterpriseWorkLocationDeletionConfirmationMessage', data.record.id);
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
            { data: "enterpriseWorkCenterId" },
            { data: "name" },
            { data: "equipmentId" },
            { data: "processId" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEnterpriseWorkLocationButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});