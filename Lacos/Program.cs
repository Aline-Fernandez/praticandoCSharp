#region Usando o for

Console.WriteLine("Contagem de 1 a 10:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("\n\nImprimi de 0 a 20 de 2 em 2:");

for (int i= 0; i <= 20; i += 2)
    { Console.WriteLine(i); }


Console.WriteLine("\n\nPercorrer array:");

int[] numeros = { 1, 2, 3, 4, 5 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

#endregion