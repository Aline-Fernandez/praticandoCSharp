#region Calculadora de IMC

using System.ComponentModel.Design;

string Nome;
double Peso;
double Altura;
double Imc;

Console.WriteLine("Preencha os campos para o calculo do seu IMC");

Console.WriteLine("\nNome: ");
Nome = Console.ReadLine();
Console.WriteLine("Seu nome digitado foi: " + Nome);

Console.WriteLine();

Console.WriteLine("Peso (kg): ");
Peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("O peso digitado foi: " + Peso);

Console.WriteLine();

Console.WriteLine("Altura (m): ");
Altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Sua altura digitada foi: " + Altura.ToString("F2"));

Imc = Peso / (Altura * Altura);
Console.WriteLine("\nO seu IMC é: " + Imc.ToString("F2"));

Console.WriteLine("\n______________________________________________________________________");

  if (Imc < 18.5)
{
    Console.WriteLine(Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nAbaixo do peso");
}

  else if (Imc >= 18.5 && Imc <= 24.9)
{
    Console.WriteLine(Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nPeso normal");
}

 else if (Imc >= 25 && Imc <= 29.9)
{
    Console.WriteLine(Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nSobrePeso");
}
 else if (Imc >= 30 && Imc <= 34.9)
        {
            Console.WriteLine(Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nObesidade Grau 1");
        }

 else if (Imc >= 35 && Imc <= 39.9)
{
    Console.WriteLine(Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nObesidade Grau 2");
}

else
        {
    Console.WriteLine(Nome + "\nSeu IMM é: " + Imc.ToString("F2") + "\nObesidade Grau 3");
}



#endregion
