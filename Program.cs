//Biblioteca que permite iniciar um vetor sem tamanho definido
using System.Collections.Generic;

int numeroDecimal, i = 0, aux = 0;
List<int> binario = new List<int>();
Console.WriteLine("Digite um numero decimal: ");
numeroDecimal = int.Parse(Console.ReadLine());

//Falar como converter um número decimal para binário

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
    do
    {
        Console.Write(binario[aux - 1]);
        i++;
        aux--;
    } while (i < binario.Count);
}

