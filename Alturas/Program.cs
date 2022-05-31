using System;
using System.Globalization;



namespace alturas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, cont;
            double soma, media, porcentagem;

            Console.WriteLine("Quantas pessoas serão digitadas");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] idades = new double[N];
            double[] alturas = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Dados da " + (i+1) + " a pessoa");
                Console.WriteLine("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Idade: ");
                idades[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine());  
            }

            soma = 0;

            for(i = 0; i < N; i++) 
            {
                soma += alturas[i];
            }

            media = soma / N;
            Console.WriteLine();
            Console.WriteLine("Altura media: " + media);

            cont = 0;  

            for(i= 0; i<N; i++)
            {
                if (idades[i] < 16)
                {
                    cont += 1;
                }
            }

            porcentagem = cont * 100 / N;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem + " % ");

            for (i = 0; i < N;i ++)
            {
                if (idades[i] < 16)
                {
                    Console.WriteLine(nomes[i]);
                }  
            }
        }
    }
}