using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, ultNome;
            int quartos, idade;
            double preco, altura;
            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (separado por espaços): ");
            string[] vet = Console.ReadLine().Split(' ');

            ultNome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
