namespace Exercício
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }
        public Conta(int numeroConta, string titularConta, double depositoInicial) : this(numeroConta, titularConta)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            if (valor > 0) { Saldo += valor; }
        }

        public void Saque(double valor)
        {
            if (valor > 0) { Saldo -= (valor+5); }
        }

        public override string ToString()
        {
            return "Conta: "+NumeroConta+", Titular: "+TitularConta+", Saldo: R$"+Saldo.ToString("0.00");
        }
    }
}
