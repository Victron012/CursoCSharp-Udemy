using System;
using System.Collections.Generic;
using System.Text;

namespace This
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this( nome, preco)
        {
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int n)
        {
            Quantidade += n;
        }

        public void RemoverProdutos(int n)
        {
            Quantidade -= n;
        }

        public override string ToString()
        {
            return Nome +
                ", R$" + Preco.ToString("0.00")
                + ", " + Quantidade
                + " unidades, Total R$" + ValorTotalEmEstoque().ToString("0.00");
        }
    }
}
