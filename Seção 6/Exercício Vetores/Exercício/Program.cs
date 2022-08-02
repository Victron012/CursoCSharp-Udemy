using System;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Aluguel[] aluguel = new Aluguel[10];
            Console.WriteLine("Quantos quartos serão alugados? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string nome, email;
                int quarto;
                Console.WriteLine("\nAluguel {0}:",i+1);
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());

                aluguel[quarto] = new Aluguel(nome, email, quarto);
            }
            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < 10; i++)
            {
                if (aluguel[i] != null)
                {
                    Console.WriteLine(aluguel[i]);
                }
            }

        }
    }
}
