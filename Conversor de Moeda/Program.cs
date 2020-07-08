using System;

namespace Conversor_de_Moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares vai comprar?");
            double quantidade = double.Parse(Console.ReadLine());

            double result = ConversorDeMoeda.Total(quantidade, cotacao);
            Console.Write(result.ToString("f2"));

        }

    }
}
