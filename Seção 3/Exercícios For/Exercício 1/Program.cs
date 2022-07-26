using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Digite um número: ");
            x = int.Parse(Console.ReadLine());
            while (x <= 0)
            {
                Console.Write("Número inválido!\nDigite novamente: ");
                x = int.Parse(Console.ReadLine());
            }
            int n = 1;
            for (int i = 1; i <= x; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
