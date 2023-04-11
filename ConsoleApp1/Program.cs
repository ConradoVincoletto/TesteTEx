using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 15, 6, 10, 2, 25, 30 };

        Console.WriteLine("Array original:");
        ArrayOriginal(numeros);

        NumerosCrescente(numeros);

        Console.WriteLine("Array em ordem crescente:");
        ArrayOriginal(numeros);
    }

    static void NumerosCrescente(int[] array)
    {
        // aplicar o for e as condicionais para o efeito cascata, ou o bubble sort.
        for (int i = 0; i < array.Length - 1; i++)
        {
            int menor = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[menor])
                {
                    menor = j;
                }
            }
            //assim ele vai comparando as posições do array, se ele é menor a posição atual, ele coloca
            //número da váriavel na memória, ele transfere o número maior para a próxima posoção, e o número menor
            //entra na atual posição.
            if (menor != i)
            {
                int ordem = array[i];
                array[i] = array[menor];
                array[menor] = ordem;
            }
        }
    }

    static void ArrayOriginal(int[] array)
    {
        foreach (int valor in array)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }
}


