using System;
using System.Globalization;


namespace ExercicioContaBancaria
{
    class ContaBancaria
    {
        public string Nome { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numero, double saldo)
        {
            this.Nome = nome;
            this.Numero = numero;
            Deposito(saldo);
        }

        public ContaBancaria(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia - 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titiular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
