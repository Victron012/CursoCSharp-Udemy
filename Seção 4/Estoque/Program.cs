using System;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: "+prod);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            prod.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: "+prod);

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            prod.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: "+prod);
        }
    }
}
