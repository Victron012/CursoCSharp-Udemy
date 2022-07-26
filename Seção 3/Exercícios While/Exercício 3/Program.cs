using System;

namespace Exercício_3
{
    class Program
    {
        static int VerificaCodigo(int x) 
        {
            while (x < 1 || x > 4)
            {
                Console.Write("Código inválido!\nDigite novamente: ");
                x = int.Parse(Console.ReadLine());
            }
            return x;
        }
        static void Main(string[] args)
        {
            int x, gas = 0, alcool = 0, diesel = 0;
            Console.Write("Digite o código: ");
            x = int.Parse(Console.ReadLine());
            x = VerificaCodigo(x);
            while (x != 4)
            {
                x = VerificaCodigo(x);
                if (x == 1) { alcool += 1; }
                else if(x == 2) { gas += 1; }
                else if(x ==3) { diesel += 1; }
                Console.Write("Digite o código: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gas);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
