﻿using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            byte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria";
            object obj1 = "João";
            object obj2 = 4.5f;
            decimal dezMax = decimal.MaxValue; // valor maximo do tipo
            decimal dezMin = decimal.MinValue; // valor minimo do tipo

            Console.WriteLine(completo);
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine("Max: {0}", dezMax);
            Console.WriteLine("Min: {0}", dezMin);
        }
    }
}
