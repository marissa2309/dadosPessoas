using System;
class negativos
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Quantos números você vai digitar?");
        n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite um numero: ");
            vet[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("VALORES NEGATIVOS:");
        for (int i = 0; i < n; i++)
        {
            if (vet[i] < 0)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
