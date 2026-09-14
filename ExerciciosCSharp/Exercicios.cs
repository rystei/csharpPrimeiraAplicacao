Dictionary<string, List<double>> aluno = new Dictionary<string, List<double>>();
aluno.Add("Telles", new List<double> {10, 8, 9 });
aluno.Add("Rystei", new List<double> {10, 8, 9, 1 });

foreach (var item in aluno)
{
    double soma = 0;

    for (int i = 0; i < item.Value.Count; i++)
    {
        soma += item.Value[i];
    }

    double media = soma / item.Value.Count; 
    Console.WriteLine($"A média do aluno {item.Key} é: {media}");
}
