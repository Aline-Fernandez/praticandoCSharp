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


Console.WriteLine("______________________________________________________________________");

Console.WriteLine();

  if (Imc < 18.5)
{
    Console.WriteLine("\nNome: " + Nome +  "\nSeu IMC é: " + Imc.ToString("F2") + "\n" + " \n18,4 ou menos" + "\nAbaixo do peso" + "\n" + "\nProcure um médico. Algumas pessoas têm um baixo peso por características do seu organismo e tudo bem. Outras podem estar enfrentando problemas, como a desnutrição. É preciso saber qual é o caso.");
}

  else if (Imc >= 18.5 && Imc <= 24.9)
{
    Console.WriteLine("Nome: " + Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nEntre 18,5  e 24,9" + "\nPeso normal" + "\nQue bom que você está com o peso normal! E o melhor jeito de continuar assim é mantendo um estilo de vida ativo e uma alimentação equilibrada.");
}

 else if (Imc >= 25 && Imc <= 29.9)
{
    Console.WriteLine("Nome: " + Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nEntre 25,0 e 29,9" + "\nSobrePeso" + "\nEle é, na verdade, uma pré-obesidade e muitas pessoas nessa faixa já apresentam doenças associadas, como diabetes e hipertensão. Importante rever hábitos e buscar ajuda antes de, por uma série de fatores, entrar na faixa da obesidade pra valer.");
}
 else if (Imc >= 30 && Imc <= 34.9)
        {
            Console.WriteLine("Nome: " + Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nEntre 30,0 e 34,9"+ "\nObesidade Grau I" + "\nSinal de alerta! Chegou na hora de se cuidar, mesmo que seus exames sejam normais. Vamos dar início a mudanças hoje! Cuide de sua alimentação. Você precisa iniciar um acompanhamento com nutricionista e/ou endocrinologista.");
        }

 else if (Imc >= 35 && Imc <= 39.9)
{
    Console.WriteLine("Nome: " + Nome + "\nSeu IMC é: " + Imc.ToString("F2") + "\nEntre 35,0 e 39,9" + "\nObesidade Grau II" + "\nMesmo que seus exames aparentem estar normais, é hora de se cuidar, iniciando mudanças no estilo de vida com o acompanhamento próximo de profissionais de saúde.");
}

else
        {
    Console.WriteLine("Nome: " + Nome + "\nSeu IMM é: " + Imc.ToString("F2") + "\n40,0 pra cima" + "\nObesidade Grau III" + "\n" +"\nAqui o sinal é vermelho, com forte probabilidade de já existirem doenças muito graves associadas. O tratamento deve ser ainda mais urgente.");
}



#endregion
