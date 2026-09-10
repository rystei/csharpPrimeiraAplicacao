// Projeto Screen Sound
//teste

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound! O seu app de streaming de música";
//List<String> listaDeBandas = new List<string> { "Skillet", "Beatles" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("sky", new List<int> { 10, 8, 9 });
bandasRegistradas.Add("AC/DC", new List<int>());


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
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Opção escolhida foi a " + opcaoEscolhidaNumerica);
            break;
        case 5:
            Console.WriteLine("Opção escolhida foi a " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Opção inválida, digite novamente");
            break;
    }
}

void RegistarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas:");
    Console.Write("Digite o nome da banda para registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda registrada foi: {nomeDaBanda} ");
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas Registradas");

    foreach (var item in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {item}");
    }
    Console.WriteLine("\nDigite uma tecla para sair");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda");
    Console.Write("Digite o nome da banda para avaliar: ");
    String nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

    }
    else
    {
        System.Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        System.Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();



