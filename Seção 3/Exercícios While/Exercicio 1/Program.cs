using System;

namespace Exercicios_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002, tentativa = 0;

            Console.WriteLine("Digite a senha: ");
            tentativa = int.Parse(Console.ReadLine());

            while (tentativa != senha)
            {
                Console.WriteLine("Senha Inválida! \nDigite a senha:");
                tentativa = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
        }
    }
}
