$(function () {

    var l = abp.localization.getResource('Solution');

    var service = solution.materials.material;
    var createModal = new abp.ModalManager(abp.appPath + 'Materials/Material/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Materials/Material/EditModal');

    var dataTable = $('#MaterialTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('Solution.Materials.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Solution.Materials.Delete'),
                                confirmMessage: function (data) {
                                    return l('MaterialDeletionConfirmationMessage', data.record.id);
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
            { data: "specification" },
            { data: "unitId" },
            { data: "remark" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewMaterialButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});