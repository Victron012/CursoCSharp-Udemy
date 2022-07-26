using System;

namespace Inicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            // double desconto = 0; é necessário criar e iniciar a váriavel para usala em um if e fora do mesmo
            if (preco > 100.0)
            {
                double desconto = preco * 0.1;
            }

            // Console.WriteLine(desconto); não é possivel usar variaveis declaradas em escopos "inferiores"
        }
    }
}
