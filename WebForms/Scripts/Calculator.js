function calculate(number1, number2, operators) {

     var result = 0;

    if (number2 == 0 && operators == 3) {
        return ("Não existe divisão por 0.");
    }

    switch (operators) {
        case 1: result = number1 + number2; break;
        case 2: result = number1 - number2; break;
        case 3: result = number1 / number2; break;
        case 4: result = number1 * number2; break;
    }

    return result;
}