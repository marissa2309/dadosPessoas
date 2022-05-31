using System;
class negativosMatriz
{
    static void Main(string[] args)
    {
        int m, n;
        Console.WriteLine("Quantos linhas e colunas na matriz? (Digite o primeiro, dê ENTER e digite o segundo)");
        m = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        int[,] mat = new int[m, n];
        Console.WriteLine("Digite os elementos da primeira matriz: ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("VALORES NEGATIVOS:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] < 0)
                {
                    Console.WriteLine(mat[i, j]);
                }
            }
        }
    }
}
