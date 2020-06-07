$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.qualities.qualityInspect;
    var createModal = new abp.ModalManager(abp.appPath + 'Qualities/QualityInspect/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Qualities/QualityInspect/EditModal');

    var dataTable = $('#QualityInspectTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.QualityInspects.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.QualityInspects.Delete'),
                                confirmMessage: function (data) {
                                    return l('QualityInspectDeletionConfirmationMessage', data.record.id);
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
            { data: "inspectPerson" },
            { data: "qualityInspectTypeId" },
            { data: "inspectTime" },
            { data: "name" },
            { data: "qualityProblemLibId" },
            { data: "qualityInspectResultId" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewQualityInspectButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});