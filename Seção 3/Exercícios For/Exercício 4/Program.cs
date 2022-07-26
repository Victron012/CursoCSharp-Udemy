using System;
using System.Collections.Generic;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double n1, n2;
            string n;
            List<string> div = new List<string>();

            Console.WriteLine("Quantos vezes irá dividir?");
            x = int.Parse(Console.ReadLine());
            while (x <= 0)
            {
                Console.WriteLine("Número inválido!\nDigite novamente: ");
            }

            for(int i = 0; i < x; i++)
            {
                n = Console.ReadLine();
                string[] s = n.Split(' ');
                n1 = double.Parse(s[0]);
                n2 = double.Parse(s[1]);
                if (n2 == 0)
                {
                    div.Add("Divisão impossivel");
                }
                else {
                    div.Add((n1/n2).ToString());
                }
            }

            div.ForEach(i => Console.WriteLine(i));
        }
    }
}
