using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorEmReais;
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.dollar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            valorEmReais = ConversorDeMoeda.Conversor(double.Parse(Console.ReadLine()));
            Console.WriteLine("Valor a ser pago em reais = R${0}", valorEmReais.ToString("0.00"));
        }
    }
}
