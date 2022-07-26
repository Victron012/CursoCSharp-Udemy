using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0, fora = 0, n, x;

            Console.WriteLine("Quantos números você irá digitar?");
            n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.Write("Número inválido!\nDigite novamente: ");
            }

            for (int i = 0; i < n; i++) {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) 
                {
                    dentro++;
                }
                else { fora++;}
            }

            Console.WriteLine("{0} in", dentro);
            Console.WriteLine("{0} out", fora);

        }
    }
}
