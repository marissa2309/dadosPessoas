using System;
class somaLinhas
{
    static void Main(string[] args)
    {
        int m, n;
        float[] vet = new float[999];
        Console.WriteLine("Quantos linhas e colunas na matriz? (Digite o primeiro, dê ENTER e digite o segundo)");
        m = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        float[,] mat = new float[m, n];
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Digite os elementos da " + (i + 1) + "linha: ");
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = float.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < m; i++)
        {
            vet[i] = 0;
            for (int j = 0; j < n; j++)
            {
                vet[i] = (vet[i] + mat[i, j]);
            }
        }
        Console.WriteLine("VETOR GERADO: ");
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(Math.Round(vet[i], 3));
        }
    }
}
