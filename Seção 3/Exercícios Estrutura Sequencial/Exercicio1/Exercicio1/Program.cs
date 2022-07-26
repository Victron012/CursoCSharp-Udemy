﻿using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 51.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é R${1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é R${1:F2}", produto2, preco2);

            Console.WriteLine("\n Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);

            Console.WriteLine("\n Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): "+ medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
