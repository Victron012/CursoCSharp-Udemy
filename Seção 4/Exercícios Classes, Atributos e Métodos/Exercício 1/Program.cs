using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " +ret.Area().ToString("0.00"));
            Console.WriteLine("Perímetro = "+ret.Perimetro().ToString("0.00"));
            Console.WriteLine("Diagonal = "+ret.Diagonal().ToString("0.00"));
        }
    }
}
