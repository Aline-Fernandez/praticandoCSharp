#region Programa calcula o estoque médio de uma peça

ushort EstoqueMinimo;
ushort EstoqueMaximo;
ushort EstoqueMedio;

while (true) // Loop infinito até que valores válidos sejam inseridos
{
    Console.WriteLine("Digite o estoque mínimo da peça: ");
    if (ushort.TryParse(Console.ReadLine(), out EstoqueMinimo))
    {
        break; // Sai do loop se a entrada for válida
    }
    Console.WriteLine("Valor inválido, tente novamente.");
}


while (true) // Loop infinito até que valores válidos sejam inseridos
{
    Console.WriteLine("Digite o estoque máximo da peça: ");
    if (ushort.TryParse(Console.ReadLine(), out EstoqueMaximo))
    {
        break; // Sai do loop se a entrada for válida
    }
        Console.WriteLine("Valor inválido, tente novamente.");
    }
    
EstoqueMedio = (ushort)((EstoqueMinimo + EstoqueMaximo) / 2);
Console.WriteLine("O estoque médio da peça é: " + EstoqueMedio);

#endregion