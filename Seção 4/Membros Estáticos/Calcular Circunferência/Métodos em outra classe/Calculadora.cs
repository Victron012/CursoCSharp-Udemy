using System;
using System.Collections.Generic;
using System.Text;

namespace Métodos_em_outra_classe
{
    class Calculadora
    {
        public static double pi = 3.14;
        public static double Circunferencia(double raio)
        {
            return 2 * pi * raio;
        }
        public static double Volume(double raio)
        {
            return (4 * pi * Math.Pow(raio, 3)) / 3;
        }
    }
}
