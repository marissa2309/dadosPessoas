using System;

class Programa
{
    static void Main(string[] args)
    {
        int N, posMaior, maior;



        Console.WriteLine("Quantas pessoas voce vai digitar? ");
        N = int.Parse(Console.ReadLine());



        string[] nomes = new string[N];
        int[] idades = new int[N];



        for (int i = 0; i < N; i++)
        {



            Console.WriteLine("Dados da " + (i + 1) + " º pessoa:");
            Console.WriteLine("Nome : ");
            nomes[i] = Console.ReadLine();
            Console.WriteLine("Idade : ");
            idades[i] = int.Parse(Console.ReadLine());

        }


        posMaior = 0;
        maior = idades[0];



        for (int i = 0; i < N; i++)
        {
            if (idades[i] > maior)
            {
                maior = idades[i];
                posMaior = i;
            }
        }

        Console.WriteLine();
        Console.WriteLine("PESSOA MAIS VELHA " + nomes[posMaior]);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();



    }
}