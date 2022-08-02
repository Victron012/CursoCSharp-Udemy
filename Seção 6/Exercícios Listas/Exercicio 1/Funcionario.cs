using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            VerificaSalario(salario);
        }
        public void VerificaSalario(double salario)
        {
            if (salario > 0) { Salario = salario; }
        }
        public void AumentaSalario(int n)
        {
            if (n > 0)
            {
                Salario += ((Salario * n) / 100);
            }
        }

        public override string ToString()
        {
            return "Id: "+Id+", Nome: "+Nome+", Salário: "+Salario;
        }
    }
}
