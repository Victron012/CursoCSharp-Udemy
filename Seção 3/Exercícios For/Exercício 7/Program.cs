using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Número inválido!\nDigite novamente: ");
            }
            for(int i =1; i <= n; i++)
            {
                Console.WriteLine("{0} {1} {2}", i, i*i, i*i*i);
            }
        }
    }
}
