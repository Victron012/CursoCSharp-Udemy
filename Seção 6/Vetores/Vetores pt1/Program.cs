using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas pessoas serão?");
            int n = int.Parse(Console.ReadLine());
            double[] altura = new double[n];
        
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Digite a altura da {0} Pessoa: ", i+1);
                altura[i] = double.Parse(Console.ReadLine());
            }
            double soma = 0;
            for(int i = 0; i<n;i++)
            {
                soma += altura[i];
            }

            Console.WriteLine("Altura média: "+ (soma/n).ToString("0.00"));
        }
    }
}
