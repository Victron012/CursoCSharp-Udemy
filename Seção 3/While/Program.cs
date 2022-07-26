using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            while ( n >= 0) {
                Console.WriteLine(Math.Sqrt(n));
                Console.Write("Digite outro número");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número negativo!");
        }
    }
}
