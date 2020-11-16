$(function () {
    var createModal = new abp.ModalManager(abp.appPath + 'HelpRequest/CreateModal');
    var createHandModal = new abp.ModalManager(abp.appPath + 'GiveAHandRequest/CreateModal');
    abp.log.debug('Index.js initialized!');
    $('#NewHelpRequestButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    })
    $('#NewGiveAHandRequestButton').click(function (e) {
        e.preventDefault();
        createHandModal.open();
    });
    createModal.onResult(function () {
        abp.notify.success("Yardım talebiniz oluşturuldu.")
    });
    createHandModal.onResult(function () {
        abp.notify.success("Yardım eli uzatma talebiniz oluşturuldu.")
    });
});
