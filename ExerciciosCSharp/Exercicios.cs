void ExibirOperacoes()
{
    float a = 3.15f;
    float b = 4.50f;

    float soma = a + b;
    float subtracao = a - b;
    float multiplicacao = a * b;
    float divisao = a / b;

    Console.WriteLine($"Soma {soma} ");
    Console.WriteLine($"subtração {subtracao} ");
    Console.WriteLine($"multiplicação {multiplicacao} ");
    Console.WriteLine($"divisão {divisao} ");
}

ExibirOperacoes();