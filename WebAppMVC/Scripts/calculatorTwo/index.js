let valueOne = "";
let valueTwo = "";

function postResult() {
    var data = {};
    data.ValueOne = Number(valueOne);
    data.SelectedOperator = $("#SelectedOperator").val();
    data.ValueTwo = getVT();
    data.Result = $("#Result").val();


    $.ajax({
        type: "POST",
        url: "/CalculatorTwo/Calculate",
        dataType: "json",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        data: data,
        success: function (res) {
            if (res.result == false || res.result == "undefined") {
                alert(res.error);
            }
            else {
                $("#Result").val(res.Result);
            }
        }, 
        error: function (error) {
            alert("There was an error posting the data to the server: " + error.responseText);
        }
    });
}

function clearLastNumber() {
    var result = document.getElementById("Result");

    if (result.value.length > 1)
        result.value = result.value.substring(0, result.value.length - 1);
}

function clearAll() {
    document.getElementById("Result").value = "";
}

function insert(num) {
    var result = document.getElementById("Result");

    result.value = result.value + num;
}

function getNumbers(operator) {
    var result = document.getElementById("Result");

    valueOne = Number(result.value);

    switch (operator) {
        case "+": SelectedOperator.value = 1; break;
        case "-": SelectedOperator.value = 2; break;
        case "/": SelectedOperator.value = 3; break;
        case "*": SelectedOperator.value = 4; break;
        default: SelectedOperator = "undefined"; break;
    }

    result.value = "";

    return valueOne;
}

function getVT() {
    var result = document.getElementById("Result");

    valueTwo = Number(result.value);

    return valueTwo;
}

$(".btn-json").click(function () {
    postResult();
});