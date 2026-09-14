//Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

Dictionary<string, int> estoque = new Dictionary<string, int>
{
    {"Café", 50},
    {"Carne", 40 },
    {"Suco", 8 }
};

string produto = Console.ReadLine()!;

if (estoque.ContainsKey(produto))
{
    Console.WriteLine($"A quantidade em estoque do produto {produto}: {estoque[produto]} unidades ");
}
else
{
    Console.WriteLine("Produto não encontrado");
}
