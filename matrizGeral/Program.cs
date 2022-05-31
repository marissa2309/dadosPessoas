using System;



namespace MatrizGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, linha, coluna;
            double somaPositivos;



            Console.WriteLine("Qual a ordem da matriz?");
            n = int.Parse(Console.ReadLine());



            double[,] vetor = new double[9, 9];



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                    vetor[i, j] = double.Parse(Console.ReadLine());
                }
            }
            somaPositivos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (vetor[i, j] > 0)
                    {
                        somaPositivos += vetor[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F2"));




            Console.WriteLine();
            Console.WriteLine("Escolha uma linha: ");
            linha = int.Parse(Console.ReadLine());
            Console.WriteLine("LINHA ESCOLHIDA: ");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(vetor[(linha - 1), j].ToString("F2"));
            }



            Console.WriteLine();
            Console.WriteLine("Escolha uma coluna: ");
            coluna = int.Parse(Console.ReadLine());
            Console.WriteLine("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i, (coluna - 1)].ToString("F2"));
            }
            Console.WriteLine();




            Console.WriteLine();
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i, i].ToString("F2"));
            }
            Console.WriteLine();



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (vetor[i, j] < 0)
                    {
                        vetor[i, j] = vetor[i, j] * vetor[i, j];
                    }
                }
            }



            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(vetor[i, j].ToString("F2"));
                }
            }




            Console.WriteLine();
            Console.WriteLine("Precione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
