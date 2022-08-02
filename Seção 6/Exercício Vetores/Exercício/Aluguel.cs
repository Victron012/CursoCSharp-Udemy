using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício
{
    class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; private set; }

        public Aluguel(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            DefineQuarto(quarto);
        }

        public void DefineQuarto(int quarto)
        {
            try
            {
                if (quarto >= 0 && quarto < 10)
                {
                    Quarto = quarto;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString()
        {
            return Quarto + ": "+Nome+", "+Email;
        }
    }
}
