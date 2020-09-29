jQuery(function ($) {
    $("input[id='consultacnpj']").click(function () {
        var cnpj_num = $('#cnpj').val();
        if (cnpj_num.length <= 13) {
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

        $.ajax(settings).done(function (result) {
            if (result.error != null) {
                alert(result.message || "Encontramos um erro na pesquisa")
            }
            $("input[name='nome']").val(result.name)
            $("input[name='dataAbertura']").val(result.founded)
            $("input[name='atividade']").val(result.primary_activity.description)
            console.log(result);
        });

        $.ajax(settings).fail(function () {
            alert("CNPJ não encontrado, tente novamente");
        })
    });
});