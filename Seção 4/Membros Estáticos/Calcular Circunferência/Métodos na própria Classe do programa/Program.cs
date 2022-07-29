using System;

namespace Métodos_na_própria_Classe_do_programa
{
    class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            Console.WriteLine("Circunferência: {0}", circ.ToString("0.00"));

            double vol = Volume(raio);
            Console.WriteLine("Volume: {0}", vol.ToString("0.00"));

            Console.WriteLine("Valor de pi: {0}", pi);
        }
        static double Circunferencia(double raio)
        {
            return 2 * pi * raio;
        }
        static double Volume(double raio)
        {
            return (4 * pi * Math.Pow(raio, 3))/3;
        }
    }
}
