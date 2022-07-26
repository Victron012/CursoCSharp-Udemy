using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num, soma = 0;
            Console.WriteLine("Quantos números você vai digitar?");
            n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Número inválido!\nDigite novamente: ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                num = int.Parse(Console.ReadLine());
                soma += num;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
