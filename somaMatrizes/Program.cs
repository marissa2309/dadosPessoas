using System;
class somaMatrizes
{
    static void Main(string[] args)
    {
        int m, n;
        Console.WriteLine("Quantos linhas e colunas na matriz? (Digite o primeiro, dê ENTER e digite o segundo)");
        m = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        float[,] mat1 = new float[m, n];
        float[,] mat2 = new float[m, n];
        float[,] mat3 = new float[m, n];
        Console.WriteLine("Digite os elementos da primeira matriz: ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                mat1[i, j] = float.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Digite os elementos da segunda matriz: ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                mat2[i, j] = float.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mat3[i, j] = mat1[i, j] + mat2[i, j];
            }
        }
        Console.WriteLine("MATRIZ SOMA:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(mat3[i, j] + " ");
            }
        }
    }
}
