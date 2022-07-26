using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que horas são?");
            int x = int.Parse(Console.ReadLine());

            if (x > 0 && x < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (x < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

            Console.WriteLine("--------------");

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Número par!");
            }
            else
            {
                Console.WriteLine("Número impar!");
            }
        }
    }
}
