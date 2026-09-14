//Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.

Dictionary<string, string> quiz = new Dictionary<string, string>
{
    {"Qual a cor do mar?", "Azul" },
    {"Qual a cor do café?", "Preto" },
    {"Quanto é 10 * 2?", "20" }
};

int pontucao = 0;

foreach (var item in quiz)
{
    Console.WriteLine(item.Key);
    Console.Write("Insira a resposta: ");
    string resposta = Console.ReadLine()!;

    if (resposta.ToLower() == item.Value.ToLower())
    {
        Console.WriteLine("Resposta correta!");
        pontucao++;
    }
    else
    {
        Console.WriteLine($"Errado, a resposta correta é {item.Value}\n");
    }
}

Console.WriteLine($"Pontuação final do jogo {pontucao}/{quiz.Count} perguntas.");