using System;

namespace Usando_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY, p;
            Triangulo x = new Triangulo(), y = new Triangulo();
            Console.WriteLine("Digite os valores do triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            p = (x.A + x.B + x.C) / 2;
            areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2;
            areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            Console.WriteLine("Área do triângulo X: {0}", areaX.ToString("0.0000"));
            Console.WriteLine("Área do triângulo Y: {0}", areaY.ToString("0.0000"));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
