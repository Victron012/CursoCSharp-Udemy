using System;
using System.Collections.Generic;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            int n, id, porcentagem;
            string nome;
            double salario;
            Console.Write("Quantos funcionários irá adicionar? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #{0}", i + 1);
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salário: ");
                salario = double.Parse(Console.ReadLine());

                while (list.FindIndex(x => x.Id == id) >= 0)
                {
                    Console.Write("Id já existente!\nEscolha outro id: ");
                    id = int.Parse(Console.ReadLine());
                }
                Funcionario funcionario = new Funcionario(id, nome, salario);
                list.Add(funcionario);
            }

            Console.Write("Insira o id do funcionário que deseja dar um aumento: ");
            id = int.Parse(Console.ReadLine());
            if(list.FindIndex(x => x.Id == id) >= 0)
            {
                Console.Write("Digite a porcentagem do aumento: ");
                porcentagem = int.Parse(Console.ReadLine());
                list.Find(x => x.Id == id).AumentaSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id não existe!");
            }

            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach (Funcionario s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
