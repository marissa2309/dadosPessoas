using System;

class Programa
{
    static void Main(string[] args)
    {
        int N, posMaior;
        float maior;
        float[] vetor = new float[99];

        Console.WriteLine("Quanto numeros voce vai digitar? ");
        N = int.Parse(Console.ReadLine());



        for (int i = 0; i < N; i++)
        {

            Console.WriteLine("Digite um numero: ");
            vetor[i] = float.Parse(Console.ReadLine());

        }
        posMaior = 0;
        maior = vetor[0];



        for (int i = 0; i < N; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
                posMaior = i;
            }
        }

        Console.WriteLine();
        Console.WriteLine("MAIOR VALOR " + maior, 2f);
        Console.WriteLine("POSOÇÃO DO MAIOR VALOR " + posMaior, 2f);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();

    }
}
