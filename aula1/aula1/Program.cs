// See https://aka.ms/new-console-template for more information
int num1, num2;
string operacao;
int resultado;
string aceitar;
Console.WriteLine("Bem vindo a primeira calculadora em c#\n");


Console.WriteLine("Deseja fazer uma operação? S/N");

for (aceitar == "s")
{
    Console.WriteLine("digite qual operação");
    operacao = Console.ReadLine();

    if (operacao == "+")
    {
        Console.WriteLine("Digite o primeiro número");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 + num2;
        Console.WriteLine($"O resultado da soma é: {resultado}");
    }
    else if (operacao == "-")
    {
        Console.WriteLine("Digite o primeiro número");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 - num2;
        Console.WriteLine($"O resultado da subtração é: {resultado}");
    }
    else if (operacao == "*")
    {
        Console.WriteLine("Digite o primeiro número");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 * num2;
        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    }
    else if (operacao == "/")
    {
        Console.WriteLine("Digite o primeiro número");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 / num2;
        Console.WriteLine($"O resultado da divisão é: {resultado}");
    }
    else
    {
        Console.WriteLine("Operação inválida");
    }
}


