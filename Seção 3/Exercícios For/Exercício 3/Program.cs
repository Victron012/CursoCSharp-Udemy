using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=1;
            double n1, n2, n3;
            List<double> media = new List<double>();
            Console.WriteLine("Quantos casos iram existir?");
            n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Valor inválido!\nDigite novamente: ");
            }

            for (int i = 0; i < n; i++)
            {
                var num = Console.ReadLine();
                string[] s = num.Split(' ');
                n1 = double.Parse(s[0]);
                n2 = double.Parse(s[1]);
                n3 = double.Parse(s[2]);
                media.Add(((n1*2) + (n2*3) + (n3*5)) / (2 + 3 + 5));
            }
            media.ForEach(i => Console.WriteLine(i.ToString("0.0", CultureInfo.InvariantCulture))); 

        }
    }
}
