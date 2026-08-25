// Projeto Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound! O seu app de streaming de música";

void ExibirMensagemDeBoasVindas()
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
            Console.WriteLine("Opção escolhida foi a " + opcaoEscolhidaNumerica);
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

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();



