void somaValores()
{
    List<int> valores = new List<int>() { 10, 20, 30 };
    int total = 0;

    foreach (var item in valores)
    {
        total += item ;
    }
    Console.WriteLine(total);
}

somaValores();