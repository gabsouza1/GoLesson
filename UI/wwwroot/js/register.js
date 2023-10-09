$(document).ready(function () {
    $("#emailInput").on("input", function () {
        var email = $(this).val();
        console.log(email);
        $.ajax({
            url: "/Usuario/VerificarEmailExistente",
            type: "GET",
            data: { email: email },
            success: function (result) {
                if (!result) {
                    $("#emailError").text("\u0045\u0073\u0074\u0065\u0020\u0065\u006d\u0061\u0069\u006c\u0020\u006a\u00e1\u0020\u0065\u0073\u0074\u00e1\u0020\u0063\u0061\u0064\u0061\u0073\u0074\u0072\u0061\u0064\u006f");
                } else {
                    $("#emailError").text("");
                }
            }
        });
    });
});

$(document).ready(function () {
    $("#senha").on("keyup", function () {
        var senha = $(this).val();
        var forcaSenha = verificarForcaSenha(senha);
        exibirMensagemForcaSenha(forcaSenha);
    });

    function verificarForcaSenha(senha) {
        var forca = 0;

        // Verificar comprimento mínimo
        if (senha.length >= 8) {
            forca += 1;
        }

        // Verificar letras maiúsculas
        if (/[A-Z]/.test(senha)) {
            forca += 1;
        }

        // Verificar letras minúsculas
        if (/[a-z]/.test(senha)) {
            forca += 1;
        }

        // Verificar números
        if (/[0-9]/.test(senha)) {
            forca += 1;
        }

        // Verificar caracteres especiais
        if (/[$#&!]/.test(senha)) {
            forca += 1;
        }

        return forca;
    }

    function exibirMensagemForcaSenha(forca) {
        var mensagem = "";

        switch (forca) {
            case 0:
                mensagem = "\u0053\u0065\u006e\u0068\u0061\u0020\u0066\u0072\u0061\u0063\u0061\u0020\u0028\u006d\u00ed\u006e\u0069\u006d\u006f\u0020\u0038\u0020\u0063\u0061\u0072\u0061\u0063\u0074\u0065\u0072\u0065\u0073\u0029";
                break;
            case 1:
                mensagem = "\u0053\u0065\u006e\u0068\u0061\u0020\u0066\u0072\u0061\u0063\u0061\u0020\u0028\u0070\u0065\u006c\u006f\u0020\u006d\u0065\u006e\u006f\u0073\u0020\u0038\u0020\u0063\u0061\u0072\u0061\u0063\u0074\u0065\u0072\u0065\u0073\u002c\u0020\u006c\u0065\u0074\u0072\u0061\u0073\u0020\u006d\u0061\u0069\u00fa\u0073\u0063\u0075\u006c\u0061\u0073\u002c\u0020\u006c\u0065\u0074\u0072\u0061\u0073\u0020\u006d\u0069\u006e\u00fa\u0073\u0063\u0075\u006c\u0061\u0073\u002c\u0020\u006e\u00fa\u006d\u0065\u0072\u006f\u0073\u0020\u0065\u0020\u0063\u0061\u0072\u0061\u0063\u0074\u0065\u0072\u0065\u0073\u0020\u0065\u0073\u0070\u0065\u0063\u0069\u0061\u0069\u0073\u0029";
                break;
            case 2:
                mensagem = "\u0053\u0065\u006e\u0068\u0061\u0020\u0072\u0061\u007a\u006f\u00e1\u0076\u0065\u006c";
                break;
            case 3:
                mensagem = "\u0053\u0065\u006e\u0068\u0061\u0020\u0062\u006f\u0061";
                break;
            case 4:
                mensagem = "\u0053\u0065\u006e\u0068\u0061\u0020\u0066\u006f\u0072\u0074\u0065";
                break;
            case 5:
                mensagem = "\u0053\u0065\u006e\u0068\u0061\u0020\u006d\u0075\u0069\u0074\u006f\u0020\u0066\u006f\u0072\u0074\u0065";
                break;
        }

        $("#senhaErro").text(mensagem);
    }
});

$(document).ready(function () {
    $('#telefone').inputmask("(99) 99999-9999", {
        'placeholder': '',
        'clearMaskOnLostFocus': false
    });
});

$(document).ready(function () {
    $('#cep').inputmask("99999-999", {
        'placeholder': '',
        'clearMaskOnLostFocus': false
    });
});

function limpa_formulario_cep() {
    $("#rua").val("");
    $("#bairro").val("");
    $("#cidade").val("");
    $("#uf").val("");
}
$(document).ready(function () {
    $("#cep").blur(function () {
        var cep = $(this).val().replace(/\D/g, '');
        if (cep != "") {
            var validacep = /^[0-9]{8}$/;
            if (validacep.test(cep)) {
                $("#rua").val("...");
                $("#bairro").val("...");
                $("#cidade").val("...");
                $("#uf").val("...");
                $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {
                    console.log(dados);
                    if (!("erro" in dados)) {
                        $("#rua").val(dados.logradouro);
                        $("#bairro").val(dados.bairro);
                        $("#cidade").val(dados.localidade);
                        $("#uf").val(dados.uf);
                    }
                    else {
                        limpa_formulario_cep();
                        alert("CEP não encontrado.");
                    }
                });
            }
            else {
                limpa_formulario_cep();
                alert("Formato de CEP inválido.");
            }
        }
        else {
            limpa_formulario_cep();
        }
    });
})

