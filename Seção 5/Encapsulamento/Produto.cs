using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
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

        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
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
