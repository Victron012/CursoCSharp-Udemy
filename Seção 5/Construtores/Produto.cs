namespace Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = 5;
        }
        public Produto()
        {
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
