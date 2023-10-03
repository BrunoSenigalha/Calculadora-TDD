using Calculadora_TDD.Utilitarios;

Calculadora calculadora = new Calculadora();
double resultado;
bool sair = false;

Console.WriteLine("Programa Calculadora \n");

while (sair != true)
{
    Console.WriteLine("Escolha as opcoes: ");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Dividir");
    Console.WriteLine("4 - Multiplicar");
    Console.WriteLine("5 - Sair");

    string opcao = Console.ReadLine();

    if (opcao == "5")
    {
        sair = true;
        break;
    }
    try
    {
        Console.Write("Digite o primeiro numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

       

        switch (opcao)
        {
            case "1":
                Console.Clear();
                resultado = calculadora.soma(num1, num2);
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case "2":
                Console.Clear();
                resultado = calculadora.subtracao(num1, num2);
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case "3":
                Console.Clear();
                resultado = calculadora.divisao(num1, num2);
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case "4":
                Console.Clear();
                resultado = calculadora.multiplicacao(num1, num2);
                Console.WriteLine($"Resultado: {resultado}");
                break;

            default:
                Console.WriteLine("Opcao desconhecida");
                break;

        }
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
} 

