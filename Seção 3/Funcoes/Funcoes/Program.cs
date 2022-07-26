using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, maior;

            Console.WriteLine("Digite três números: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            maior = Maior(n1, n2, n3);
;            

            Console.WriteLine("Maior: "+ maior);

        }

        private static double Maior(double n1, double n2, double n3)
        {
            double maior;
            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            return maior;
        }
    }
}
