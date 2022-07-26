using System;

namespace Funções_Sintaxe_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números:");
            int n1, n2, n3;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > 3)
            {
                return n1;
            }
            else if (n2 > n3)
            {
                return n2;
            }
            else { return n3; }
        }
    }
}
