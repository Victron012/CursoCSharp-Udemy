using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario(), y = new Funcionario();
            double media;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine());

            media = (x.Salario + y.Salario) / 2;

            Console.WriteLine("Salário médio: {0}", media.ToString("0.00"));


        }
    }
}
