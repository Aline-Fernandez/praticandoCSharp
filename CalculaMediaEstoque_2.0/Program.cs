#region Programa calcula o estoque médio de uma peça

int EstoqueMinimo;
int EstoqueMaximo;
int EstoqueMedio;

while (true) // Loop infinito até que valores válidos sejam inseridos
{
    Console.WriteLine("Digite o estoque mínimo da peça: ");
    EstoqueMinimo = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o estoque máximo da peça: ");
    EstoqueMaximo = int.Parse(Console.ReadLine());

    if (EstoqueMinimo >= 0 && EstoqueMaximo >= 0 &&  EstoqueMaximo > EstoqueMinimo)
    {
        break; // Sai do loop se a entrada for válida
    }
    else
    {
        Console.Clear(); //Limpa a tela e exibe mensagem de erro
        Console.WriteLine("Digitado valor negativo ou valor máximo menor que valor minimo. Digite novamente.\n");
    }
}

EstoqueMedio = (int)((EstoqueMinimo + EstoqueMaximo) / 2);
Console.WriteLine("O estoque médio da peça é: " + EstoqueMedio);

#endregion
