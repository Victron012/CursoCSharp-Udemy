using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += ((porcentagem * SalarioBruto) / 100);
        }
        public override string ToString()
        {
            return Nome + ", R$" + SalarioLiquido().ToString("0.00");
        }
    }
}
