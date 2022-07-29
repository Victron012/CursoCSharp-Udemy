using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            for(int i = 0; i < 3; i++)
            {
                a.Notas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nota final = "+ a.NotaFinal().ToString("0.00"));
            if (a.Aprovado()) { Console.WriteLine("Aprovado!"); }
            else { Console.WriteLine("Reprovado!\nFaltaram {0} pontos", a.NotaFaltante().ToString("0.00")); }
        }
    }
}
