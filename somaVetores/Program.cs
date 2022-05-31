using System;
class somaVetores
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Quantos valores vão ter os vetores?");
        n = int.Parse(Console.ReadLine());
        int[] vet1 = new int[n];
        int[] vet2 = new int[n];
        int[] vet3 = new int[n];
        Console.WriteLine("Digite os elementos do primeiro vetor: ");
        for (int i = 0; i < n; i++)
        {
            vet1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Digite os elementos do segundo vetor: ");
        for (int i = 0; i < n; i++)
        {
            vet2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            vet3[i] = vet1[i] + vet2[i];
        }
        Console.WriteLine("VETOR RESULTANTE: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(vet3[i]);
        }
    }
}
