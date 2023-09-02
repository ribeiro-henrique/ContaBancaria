
using System.Globalization;


namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();

            Console.Write("Deseja fazer um deposito inicial (s/n) ? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S') {
                Console.Write("Digite o valor desejado: ");
                double vInitial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(id, titular, vInitial);
            } else {
                conta = new ContaBancaria(id, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Deposite um valor: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Valor do saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}