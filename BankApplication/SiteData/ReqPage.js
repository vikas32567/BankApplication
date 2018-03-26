$(function () {
    var accNo = $('#AccNo');
    var accBal = $('#AccBal');
    var accType = $('#AccType');
    $('#SubmitBtn').on('click', function () {
        var account = {
            AccNo: accNo.val,
            AccBal: accBal.val,
            AccType: accType.val
        };
        $ajax({
            type:'POST'
        });
    });
});