﻿using System;

namespace Expressão_condicional_ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = (preco<20)?preco*0.1:preco*0.05; // se verdadeiro | se falso
            Console.WriteLine(desconto);
        }
    }
}
