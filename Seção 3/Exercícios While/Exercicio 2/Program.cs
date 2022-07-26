using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Digite a coordenada de X e Y:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0) { Console.WriteLine("Primeiro"); }
                else if (x < 0 && y > 0) { Console.WriteLine("Segundo"); }
                else if (x < 0 && y < 0) { Console.WriteLine("Terceiro"); }
                else { Console.WriteLine("Quarto"); }

                Console.WriteLine("Digite a coordenada de X e Y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
