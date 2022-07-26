﻿using System;

namespace OperadorAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            double a = 1.0, b = -3.0, c = -4.0, delta, x1, x2;

            delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Math.Pow usado para calcular potenciação 
            x1 = (-b + Math.Sqrt(delta)) / (2 * a); // Math.Sqtr usado para calcular raiz quadrada
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Baskhara: \n x1: {0} \n x2: {1}", x1, x2);


        }
    }
}
