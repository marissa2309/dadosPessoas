using System;



class Programa
{
    static void Main(string[] args)
    {
        int N, cont;
        int[,] vetor = new int[99, 99];



        Console.WriteLine("Qual a ordem da matriz?");
        N = int.Parse(Console.ReadLine());



        for (int i = 0; i < N; i++)
        {



            for (int j = 0; j < N; j++)
            {



                Console.WriteLine("Elemento [ " + i + "," + j + "]");
                vetor[i, j] = int.Parse(Console.ReadLine());
            }

        }

        Console.WriteLine("DIAGONAL PRINCIPAL: ");



        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(vetor[i, i] + " ");
        }



        cont = 0;



        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (vetor[i, j] < 0)
                {
                    cont = cont + 1;
                }
            }
        }



        Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + cont);



        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();



    }
}
