using System;



namespace MediaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma, contPares;
            float media;



            Console.WriteLine("Quantos elementos vai ter o vetor?");
            n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }



            soma = 0;
            contPares = 0;



            for (int i = 0; i < n; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    soma += vetor[i];
                    contPares++;
                }
            }
            if (contPares == 0)
            {
                Console.WriteLine("NENHUM NÚMERO PAR");
            }
            else
            {
                media = soma / contPares;
                Console.WriteLine("MEDIA PARES = " + media.ToString("F2"));



            }



            Console.WriteLine();
            Console.WriteLine("Precione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
