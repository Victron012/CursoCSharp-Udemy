using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_3
{
    class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];
        
        public double NotaFinal()
        {
            double soma = 0;
            for (int i = 0; i < 3; i++)
            {
                soma += Notas[i];
            }
            return soma;
        }
        public double NotaFaltante()
        {
            return 60 - NotaFinal();
        }
        public bool Aprovado()
        {
            double soma;
            bool aprovado;
            soma = NotaFinal();
            if (soma > 60) { aprovado = true;}
            else { aprovado = false; }
            return aprovado;
        }
    }
}
