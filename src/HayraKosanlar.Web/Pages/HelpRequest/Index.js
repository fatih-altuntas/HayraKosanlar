$(function () {
    var l = abp.localization.getResource('HayraKosanlar');
    var createModal = new abp.ModalManager(abp.appPath + 'HelpRequest/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'HelpRequest/EditModal');

    var dataTable = $('#HelpRequestsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(hayraKosanlar.helpRequest.helpRequest.getList),
            columnDefs: [
                {
                    title: l('Name'),
                    data: "name"
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
                //{
                //    title: l('PublishDate'),
                //    data: "publishDate",
                //    render: function (data) {
                //        return luxon
                //            .DateTime
                //            .fromISO(data, {
                //                locale: abp.localization.currentCulture.name
                //            }).toLocaleString();
                //    }
                //},
                //{
                //    title: l('Price'),
                //    data: "price"
                //},
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
                },
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
