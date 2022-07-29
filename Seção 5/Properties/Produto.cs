using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int n)
        {
            _quantidade += n;
        }

        public void RemoverProdutos(int n)
        {
            _quantidade -= n;
        }

        public override string ToString()
        {
            return _nome +
                ", R$" + _preco.ToString("0.00")
                + ", " + _quantidade
                + " unidades, Total R$" + ValorTotalEmEstoque().ToString("0.00");
        }
    }
}

