/// <reference path="../jquery-3.1.0.intellisense.js" />
function chamadaSimples(url, callBack) {
    $.ajax({
        type: 'GET',
        url: url,
        async: true,
        success: function (data) { callBack; }
    });
}

function chamadaSimplesPost(url, data, callBack) {
    $.ajax({
        type: 'POST',
        async: true,
        url: url,
        data: data,
        success: function (data) { callBack; }
    });
}