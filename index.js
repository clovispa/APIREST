$('#btnBuscar').click(function (e) {

    var codigoIso = $('#codigoPais').val();
    if (codigoIso.length != 3) {
        alert("El código debe de contener 3 caracteres alfanumericos");
        return false;
    }

    var vsExprReg = /[A-Za-z0-9_]/;

    if (!vsExprReg.test(codigoIso)) {
        alert("El código olo debe contener caracteres alfanumericos");
        return false;
    }
});