using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Digite o número que quer calcular o fatorial: ");
            x = int.Parse(Console.ReadLine());
            while (x < 0)
            {
                Console.WriteLine("Valor inválido!\nDigite novamente: ");
            }
            if (x == 0)
            {
                x = 1;
            }
            else
            {
                int num = x;
                for (int i = x-1; i > 0; i--)
                {
                    x = x * i;
                }
            }
            Console.WriteLine(x);
        }
    }
}
