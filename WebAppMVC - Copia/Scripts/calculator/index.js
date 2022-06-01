function postResult() {
    var data = {};
    data.NumberOne = $("#NumberOne").val();
    data.SelectedOperator = $("#SelectedOperator").val();
    data.NumberTwo = $("#NumberTwo").val();

    $.ajax({
        type: "POST",
        url: "/Calculator/Calculate",
        dataType: "json",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        data: data,
        success: function (res) {
            $("#Result").val(res.Result);
        },
        error: function (error) {
            alert("There was an error posting the data to the server: " + error.responseText);
        }
    });
}

function getResult() {
    var data = {};
    data.NumberOne = $("#NumberOne").val();
    data.SelectedOperator = $("#SelectedOperator").val();
    data.NumberTwo = $("#NumberTwo").val();

    $.getJSON("/Calculator/GetCalculate", data, function (res) { $("#Result").val(res.Result); })
        .error(function (error) {
            alert("There was an error posting the data to the server: " + error.responseText);
        });
};