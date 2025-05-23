using System.Globalization;

namespace Exercise01
{
    internal class DadosBancarios
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double Taxa = 5.00;

        public DadosBancarios(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public DadosBancarios(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double dinheiro)
        {
            Saldo += dinheiro;
        }

        public void Saque(double dinheiro)
        {
            Saldo -= (dinheiro + Taxa);
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
