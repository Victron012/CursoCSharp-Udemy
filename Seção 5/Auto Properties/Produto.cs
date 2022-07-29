using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_Properties
{
    class Produto
    {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome +
                ", R$" + Preco.ToString("0.00")
                + ", " + Quantidade
                + " unidades, Total R$" + ValorTotalEmEstoque().ToString("0.00");
        }
    }
}
