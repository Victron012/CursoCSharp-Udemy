using System;
using System.Collections.Generic;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            List<int> lista = new List<int>();
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Número inválido!\nDigite novamente: ");
            }
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0) 
                {
                    lista.Add(i);
                }
            }
            Console.WriteLine("Divisores: ");
            lista.ForEach(i => Console.WriteLine(i));
        }
    }
}
