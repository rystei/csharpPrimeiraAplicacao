Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 100);

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine()!);

    {
        if (chute == numeroSecreto)
        {
            Console.WriteLine("Acertou");
            break;
        }
        else if (chute > numeroSecreto)
        {
            Console.WriteLine("O chute é maior que o numero secreto");
        }
        else
        {
            Console.WriteLine("O chute é menor que o numero secreto");
        }

    }

} while (true);
