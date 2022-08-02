using System;

namespace Vetores_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos serão: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];
            for (int i = 0; i < n; i++)
            {
                string nome;
                double preco;
                Console.WriteLine("Entre com o nome do {0} produto: ", i + 1);
                nome = Console.ReadLine();
                Console.WriteLine("Entre com o preço do {0} produto: ", i + 1);
                preco = double.Parse(Console.ReadLine());
                vetor[i] = new Produto(nome, preco);
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Preco;
            }

            Console.WriteLine("Preço médio = " + (soma / n).ToString("0.00"));
        }

    }
}

