using System;
using System.Collections.Generic;
using System.Text;

namespace Iniciar_valores_sem_construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
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
