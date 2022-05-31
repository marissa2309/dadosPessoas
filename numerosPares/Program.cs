using System;
class numerosPares
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Quantos números você vai digitar?");
        n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite um número: ");
            vet[i] = int.Parse(Console.ReadLine());
        }
        int qtdePares = 0;
        Console.WriteLine("NUMEROS PARES:");
        for (int i = 0; i < n; i++)
        {
            if (vet[i] % 2 == 0)
            {
                Console.WriteLine(vet[i] + " ");
                qtdePares++;
            }
        }
        Console.WriteLine("QUANTIDADE DE PARES: " + qtdePares);
    }
}