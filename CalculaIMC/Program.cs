#region Calculadora de IMC

string Nome;
double Peso;
double Altura;
double Imc;

Console.WriteLine("Digite seu nome: ");
Nome = Console.ReadLine();
Console.WriteLine("Seu nome digitado foi: " + Nome);

Console.WriteLine();

Console.WriteLine("Digite seu peso (kg): ");
Peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("O peso digitado foi: " + Peso);

Console.WriteLine();

Console.WriteLine("Digite sua altura (m): ");
Altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Sua altura digitada foi: " + Altura);


#endregion
