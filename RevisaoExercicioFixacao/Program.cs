using System.Globalization;

Console.WriteLine("Digite o seu nome completo: ");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa? ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu último nome, idade e altura: ");
string[] vet = Console.ReadLine().Split(' ');
string sobrenome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(sobrenome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
