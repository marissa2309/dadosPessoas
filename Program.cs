using System;
class comerciante
{
    static void Main(string[] args)
    {
        int n, abaixo, entre, acima;
        float totalCompra, totalVenda, totalLucro, lucro, percentualLucro; Console.WriteLine("Quantos produtos?");
        n = int.Parse(Console.ReadLine()); float[] precosCompra = new float[n];
        float[] precosVenda = new float[n];
        string[] nomes = new string[n]; for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Produto " + (i + 1) + ":");
            Console.WriteLine("Nome: ");
            nomes[i] = Console.ReadLine();
            Console.WriteLine("Preço da compra: ");
            precosCompra[i] = float.Parse(Console.ReadLine());
            Console.WriteLine("Preço da venda: ");
            precosVenda[i] = float.Parse(Console.ReadLine());
        }
        abaixo = 0;
        entre = 0;
        acima = 0; for (int i = 0; i < n; i++)
        {
            lucro = precosVenda[i] - precosCompra[i];
            percentualLucro = (lucro * 100) / precosCompra[i]; if (percentualLucro < 10)
            {
                abaixo++;
            }
            else
            {
                if (percentualLucro <= 20)
                {
                    entre++;
                }
                else
                {
                    acima++;
                }
            }
        }
        totalCompra = 0;
        totalVenda = 0; for (int i = 0; i < n; i++)
        {
            totalCompra += precosCompra[i];
            totalVenda += precosVenda[i];
        }
        totalLucro = totalVenda - totalCompra; Console.WriteLine("RELATÓRIO: ");
        Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
        Console.WriteLine("Lucro entre 10% e 20%: " + entre);
        Console.WriteLine("Lucro acima de 20%: " + acima);
        Console.WriteLine("Valor total de compra: " + Math.Round(totalCompra, 2));
        Console.WriteLine("Valor total de venda: " + Math.Round(totalVenda, 2));
        Console.WriteLine("Lucro total: " + Math.Round(totalLucro, 2));
    }
}


