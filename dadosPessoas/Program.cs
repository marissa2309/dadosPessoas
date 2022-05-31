using System;

class Programa
{
    static void Main(string[] args)
    {
        int N, contMulheres, contHomens;
        float menorAltura, maiorAltura, soma, media;
        string[] generos = new string[99];
        float[] alturas = new float[99];



        Console.WriteLine("Quantas pessoas serão digitadas? ");
        N = int.Parse(Console.ReadLine());



        for (int i = 0; i < N; i++)
        {




            Console.WriteLine("Altura da " + (i + 1) + " º pessoa: ");
            alturas[i] = float.Parse(Console.ReadLine());



            Console.WriteLine("Genero da " + (i + 1) + " º pessoa: ");
            generos[i] = Console.ReadLine();



        }



        menorAltura = alturas[0];
        maiorAltura = alturas[0];



        for (int i = 0; i < N; i++)
        {
            if (alturas[i] > maiorAltura)
            {
                maiorAltura = alturas[i];
            }



            if (alturas[i] < menorAltura)
            {
                menorAltura = alturas[i];
            }



        }



        Console.WriteLine("Menor altura : " + menorAltura, 2f);
        Console.WriteLine("Maior altura : " + maiorAltura, 2f);



        soma = 0;



        contMulheres = 0;



        for (int i = 0; i < N; i++)
        {
            if (generos[i] == "F" || generos[i] == "Feminino")
            {
                soma = soma + alturas[i];
                contMulheres = contMulheres + 1;
            }
        }



        if (contMulheres == 0)
        {
            Console.WriteLine("Impossivel calcular a altura media das mulheres");
        }
        else
        {
            media = soma / contMulheres;
            Console.WriteLine("Media das alturas das mulheres é " + media, 2f);
        }



        contHomens = N - contMulheres;
        Console.WriteLine("Numero de homens é " + contHomens);







        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();



    }
}
