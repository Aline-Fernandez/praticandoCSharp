#region Calculo para notas do aluno

string NomeAluno;
string RaAluno;
double Prova1;
double Prova2;
double Trabalho1;
double Trabalho2;
double MediaFinal;


Console.WriteLine("Digite o nome do aluno: ");
NomeAluno = Console.ReadLine();

Console.WriteLine("Digite o RA do aluno: ");
RaAluno = Console.ReadLine();


//Validação da nota da Prova1
while (true)
{
    Console.WriteLine("Digite a nota da Prova 1: ");
    Prova1 = Convert.ToDouble(Console.ReadLine());

    if (Prova1 >= 0 && Prova1 <= 10)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nota inválida, digite uma nota entre 0 e 10");
    }
}


//Validação da nota da Prova2
while (true)
{
    Console.WriteLine("Digite a nota da Prova 2: ");
    Prova2 = Convert.ToDouble(Console.ReadLine());

    if (Prova2 >= 0 && Prova2 <= 10)
    {
        break; // Sai do loop se a nota for válida
    }
    else
    {
        Console.WriteLine("Nota inválida, digite uma nota entre 0 e 10");
    }
}


//Validação da nota do Trabalho1    
while (true)
{
    Console.WriteLine("Digite a nota do Trabalho 1: ");
    Trabalho1 = Convert.ToDouble(Console.ReadLine());

    if (Trabalho1 >= 0 && Trabalho1 <= 10)
    {
        break; // Sai do loop se a nota for válida
    }
    else
    {
        Console.WriteLine("Nota inválida, digite uma nota entre 0 e 10");
    }
}


//Validação da nota do Trabalho2    
while (true)
{
    Console.WriteLine("Digite a nota do Trabalho 2: ");
    Trabalho2 = Convert.ToDouble(Console.ReadLine());

    if (Trabalho2 >= 0 && Trabalho2 <= 10)
    {
        break; // Sai do loop se a nota for válida
    }
    else
    {
        Console.WriteLine("Nota inválida, digite uma nota entre 0 e 10");
    }
}


MediaFinal = (Prova1 + Prova2 + Trabalho1 + Trabalho2) / 4;
Console.WriteLine("A média final do aluno é: " + MediaFinal.ToString("F2"));


if (MediaFinal >= 7)
{
    Console.WriteLine("O aluno foi aprovado!");
}
else
{
    Console.WriteLine("O aluno foi reprovado!");
}
#endregion