using System;

namespace Iniciar_valores_sem_construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod;
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Deseja informar a quantidade em estoque?(S/N)");
            string desicao = Console.ReadLine().ToUpper();
            while (desicao != "S" && desicao != "N")
            {
                Console.WriteLine("Resposta inválida!\nDigite novamente:");
                desicao = Console.ReadLine().ToUpper();
            }
            if (desicao == "S")
            {
                Console.Write("Quantidade em estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                prod = new Produto
                {
                    Nome = nome,
                    Preco = preco,
                    Quantidade = quantidade
                };
            }
            else
            {
                prod = new Produto(nome, preco);
            }

            Console.WriteLine("Dados do produto: " + prod);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            prod.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + prod);

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            prod.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + prod);
        }
    }
}
