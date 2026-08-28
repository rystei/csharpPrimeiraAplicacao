String[] jogos = { "GTA", "FIFA", "MARIO", "MINECRAFT" };

Console.WriteLine("Digite o nome do jogo que deseja buscar: "); 
int posicaoLista = int.Parse(Console.ReadLine()!);

Console.WriteLine(jogos[posicaoLista]);
