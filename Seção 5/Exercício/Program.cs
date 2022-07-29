using System;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            int numConta;
            string titularConta, decisao;
            double valor;
            Console.Write("Entre o número da conta: ");
            numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            titularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (S/N): ");
            decisao = Console.ReadLine().ToUpper();
            while (decisao != "S" && decisao != "N")
            {
                Console.WriteLine("Opção inválida!\nDigite novamente:");
                decisao = Console.ReadLine().ToUpper();
            }
            if (decisao == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                conta = new Conta(numConta, titularConta, valor);
            }
            else
            {
                conta = new Conta(numConta, titularConta);
            }

            Console.WriteLine("Dados da conta:\n"+conta);
            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:\n"+conta);
            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:\n" + conta);
        }
    }
}
