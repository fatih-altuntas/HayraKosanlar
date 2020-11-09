$(function () {
    $('#HelpRequest_Status').css('pointer-events', 'none');
    $('#HelpRequest_Status').parent().css('cursor', 'no-drop');

    var l = abp.localization.getResource('HayraKosanlar');
    var createModal = new abp.ModalManager(abp.appPath + 'HelpRequest/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'HelpRequest/EditModal');

    var dataTable = $('#HelpRequestsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            orderCellsTop: true,
            fixedHeader: true,
            paging: true,
            order: [[1, "asc"]],
            searching: true,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(hayraKosanlar.helpRequests.helpRequest.getList),
            columnDefs: [
                {
                    title: l('Name'),
                    data: "name",
                    searchable: "true"
                },
                {
                    title: l('Surname'),
                    data: "surname"
                },
                {
                    title: l('IdentityNumber'),
                    data: "identityNumber"
                },
                {
                    title: l('PhoneNumber'),
                    data: "phoneNumber"
                },
                {
                    title: l('ExtraInformation'),
                    data: "extraInformation"
                },
                {
                    title: l('Status'),
                    data: "status",
                    render: function (data) {
                        return l('Enum:HelpRequestStatus:' + data);
                    }
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('HayraKosanlar.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                }
                            ]
                    }
                }
            ]
        })
    );
    $('#NewHelpRequestButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    })
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });
    createModal.onResult(function () {
        dataTable.ajax.reload();
    })
    
});
