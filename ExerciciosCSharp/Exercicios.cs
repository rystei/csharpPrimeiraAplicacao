//Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

Dictionary<string, string> login =  new Dictionary<string, string>
{
    {"Telles", "123" },
    {"Admin", "admin" }
};

Console.Write("Digite o login: ");
string usuario = Console.ReadLine()!;
Console.Write("Digite a senha: ");
string senha = Console.ReadLine()!;

if (login.ContainsKey(usuario) && login[usuario] == senha)
{
    Console.WriteLine("Login bem-sucedido!");
}
else
{
    Console.WriteLine("Nome de usuário ou senha incorretos.");
}
