//Biblioteca que permite iniciar um vetor sem tamanho definido
using System.Collections.Generic;

int numeroDecimal, i = 0, aux = 0;
List<int> binario = new List<int>();
Console.WriteLine("Digite um numero decimal: ");
numeroDecimal = int.Parse(Console.ReadLine());

//Para converter um número na base 10 (usa algarismos de 0 a 9) para a base 2 (usa 0 e 1) é necessario ficar dividindo esse número por 2
//até ele ser 0 ou 1, o resto dessas divisões só pode ser 0 ou 1, assim como a ultima divisão só pode ser 0 ou 1. O resto dessas divisões e o resultado da
//ultima conta também vai ser 0 ou 1

//Verifica se o número que a pessoa digitou foi 0 ou 1
if (numeroDecimal == 0)
{
    binario.Add(0);
    Console.WriteLine($"{numeroDecimal} em binario é igual a {binario[0]}");
}
else if (numeroDecimal == 1)
{
    binario.Add(1);
    Console.WriteLine($"{numeroDecimal} em binario é igual a {binario[0]}");
}
//Se não for vai começar o laço de repetição que vai ficar dividindo o número até o número ser igual a 0 ou 1
else
{
    while (numeroDecimal > 1)
    {
        if (numeroDecimal % 2 == 0)
        {
            binario.Add(0);
            numeroDecimal = numeroDecimal / 2;
        }
        else
        {
            binario.Add(1);
            numeroDecimal = numeroDecimal / 2;
        }
    }
    //Está faltando pegar o resto dessa divisão
    if (numeroDecimal == 0)
    {
        binario.Add(0);
    }
    else
    {
        binario.Add(1);
    }
    aux = binario.Count;
    //Laço de repetição que vai imprimir todos os restos, só que ao contrario
    do
    {
        Console.Write(binario[aux - 1]);
        i++;
        aux--;
    } while (i < binario.Count);
}

