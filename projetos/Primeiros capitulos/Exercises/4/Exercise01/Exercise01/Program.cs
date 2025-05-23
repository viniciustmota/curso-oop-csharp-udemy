using System.Globalization;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DadosBancarios conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char fazerDepositoInicial = char.Parse(Console.ReadLine());
            if(fazerDepositoInicial == 's' || fazerDepositoInicial == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new DadosBancarios(numero, titular, depositoInicial);
            }
            else
            {
                conta = new DadosBancarios(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"{conta}");
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(dinheiro);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"{conta}");
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(dinheiro);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"{conta}");
        }
    }
}