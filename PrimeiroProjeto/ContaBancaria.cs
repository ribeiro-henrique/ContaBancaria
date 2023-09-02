

using System.Globalization;

namespace PrimeiroProjeto {
    internal class ContaBancaria {

        //atributos da minha classe
        public int Id { get; private set; } //id da conta, não pode ser alterado (encapsulamento)
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //meu construtor de classe com dois arg, uma vez que o saldo começa com zero
        public ContaBancaria(int id, string titular) {
            Id = id;
            Titular = titular;
        }

        // conceito de sobregarga, onde há uma reutilização do construtor anterior com this
        public ContaBancaria(int id, string titular, double saldo) : this(id, titular) {
            Saldo = saldo;
        }

        // métodos da classe

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor + 5.0;
        }

        // adicionar uma saída toString

        public override string ToString() {
            return $"Conta: {Id}\n" +
                   $"Titular: {Titular}\n" +
                   $"Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
