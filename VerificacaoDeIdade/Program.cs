#region codigo para verificar a idade do usuario

string Nome;
int Idade;

Console.WriteLine("Digite seu Nome: ");
Nome = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Digite sua idade: ");
Idade = int.Parse(Console.ReadLine());

if (Idade < 13)
{
    Console.WriteLine("Você é considerado uma criança");
}

else if (Idade >= 13 && Idade <= 17)
{
    Console.WriteLine("Você é considerado um adolecente");
}

else if (Idade >= 18 && Idade <= 59)
{
    Console.WriteLine("Você é considerado um adulto");
}

else
{
    Console.WriteLine("Você é considerado um idoso");
}

#endregion
