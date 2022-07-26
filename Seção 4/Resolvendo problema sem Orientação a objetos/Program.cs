using System;
using System.Globalization;

namespace Resolvendo_problema_sem_Orientação_a_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, areaX, areaY;
            Console.WriteLine("Entre com as medidas do triângulo X:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            p = (a + b + c) / 2;

            areaX = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            p = (a + b + c) / 2;

            areaY = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Área de X = {0}", areaX.ToString("0.0000"), CultureInfo.InvariantCulture);
            Console.WriteLine("Área de Y = {0}", areaY.ToString("0.0000"), CultureInfo.InvariantCulture);
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
