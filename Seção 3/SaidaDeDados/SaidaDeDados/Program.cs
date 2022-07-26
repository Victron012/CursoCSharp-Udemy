using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            Console.WriteLine("Bom dia!");
            Console.Write("Boa tarde!");
            Console.WriteLine("Ola");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Genero: {0}", genero);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Saldo: {0}",saldo);
            Console.WriteLine("Nome: {0}",nome);
            Console.WriteLine("Saldo: {0}", saldo.ToString("F2"));
            Console.WriteLine("Saldo: {0}", saldo.ToString("F4"));
            Console.WriteLine("Saldo: {0}", saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("----------------------");

            Console.WriteLine("{0} tem {1} anos e tem um saldo de R${2:f2}!", nome, idade, saldo);
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o saldo: ");
            saldo = double.Parse(Console.ReadLine());
            Console.WriteLine($"{nome} tem {idade} anos e tem um saldo de R${saldo:f2}!");
        }
    }
}
