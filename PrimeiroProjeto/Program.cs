// Projeto Screen Sound
//teste

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound! O seu app de streaming de música";

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███╗░░░███╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░████║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔████╔██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚██╔╝██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░╚═╝░██║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nMenu Principal:");
    Console.WriteLine("1. Registrar uma banda");
    Console.WriteLine("2. Exibir todas as bandas");
    Console.WriteLine("3. Avaliar uma banda");
    Console.WriteLine("4. Visualizar a média de uma banda");
    Console.WriteLine("5. Para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistarBanda();
            break;
        case 2: 
            Console.WriteLine("Opção escolhida foi a " + opcaoEscolhidaNumerica);
            break;
        case 3:
            Console.WriteLine("Opção escolhida foi a " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Opção escolhida foi a " + opcaoEscolhidaNumerica);
            break;
        case 5:
            Console.WriteLine("Opção escolhida foi a " + opcaoEscolhidaNumerica);
            break;
        default : Console.WriteLine("Opção inválida, digite novamente");
            break;
    }
}

void RegistarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas:");
    Console.Write("Digite o nome da banda para registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda registrada foi: {nomeDaBanda} ");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();



