using System;

namespace Métodos_em_outra_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferência: {0}", circ.ToString("0.00"));

            double vol = Calculadora.Volume(raio);
            Console.WriteLine("Volume: {0}", vol.ToString("0.00"));

            Console.WriteLine("Valor de pi: {0}", Calculadora.pi);
        }

    }
}
