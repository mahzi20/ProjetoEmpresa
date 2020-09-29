function onlynumber(evt) {
    var theEvent = evt || window.event;
    var key = theEvent.keyCode || theEvent.which;
    key = String.fromCharCode(key);
    var regex = /^[0-9.]+$/;
    if (!regex.test(key)) {
        theEvent.returnValue = false;
        if (theEvent.preventDefault) theEvent.preventDefault();
    }


}
function btndisable(evt) {
    var cnpj_num = $('#cnpj').val();

    if (cnpj_num.length < 14) {
        $(":submit").attr("disabled", true);
    }
}