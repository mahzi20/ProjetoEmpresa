jQuery(function ($) {
    $("input[id='consultacnpj']").click(function () {
        var cnpj_num = $('#cnpj').val();
        if (cnpj_num.lenght <= 17) {
            alert("O CNPJ precisa conter 14 números")
            return
        }

        var settings = {
            "async": true,
            "crossDomain": true,
            "url": "https://api.cnpja.com.br/companies/" + cnpj_num + "?company_max_age=90",
            "method": "GET",
            "headers": {
                "authorization": "ab87c454-e04a-410c-bead-66a87798676e-bd3bd420-ac29-488f-ade5-e9749d213c02"
            }
        }

        $.ajax(settings).done(function (response) {
            $("input[name='nome']").val(response.name)
            $("input[name='dataAbertura']").val(response.founded)
            $("input[name='atividade']").val(response.primary_activity.description)
            console.log(response);
        });
    });
});