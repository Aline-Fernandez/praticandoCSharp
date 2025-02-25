#region Verificar se usuario é +18 para prosseguir com cadastro


int Idade;
string Nome;
string RG;
string CPF;

while(true)
{
    Console.WriteLine("Digite sua idade: ");
    Idade = int.Parse(Console.ReadLine());

    if (Idade >= 18)
    {
        Console.WriteLine("Idade válida ");
        break;
    }
    else { 

     Console.WriteLine("Você não tem idade suficiente para prosseguir com o cadastro");
    }

 }

Console.WriteLine("Digite seu nome: ");
Nome = Console.ReadLine();

Console.WriteLine("Digite seu RG: ");
RG = Console.ReadLine();

Console.WriteLine("Digite seu CPF: ");
CPF = Console.ReadLine();

Console.WriteLine("Cadastro realizado com sucesso!");


#endregion