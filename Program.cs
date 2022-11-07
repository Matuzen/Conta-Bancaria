using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
             int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá Depósiito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.WriteLine("Dados da conta");
                conta = new ContaBancaria(nome, numero, deposito);
                Console.WriteLine(conta);
            }

            else
            {
                Console.WriteLine("Dados da conta");
                conta = new ContaBancaria(nome, numero);
                Console.WriteLine(conta);
            }

            Console.Write("Deseja fazer outro depósito? (s/n) ");
            resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(deposito);
                Console.WriteLine();
                Console.WriteLine("Dados da conta");
                Console.WriteLine(conta);
            }

            else
            {
                Console.WriteLine("Dados da conta");
                conta = new ContaBancaria(nome, numero);
                Console.WriteLine(conta);
            }

            Console.Write("Deseja fazer saque? (s/n) ");
            resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de saque: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(deposito);
                Console.WriteLine();
                Console.WriteLine("Dados da conta");
                Console.WriteLine(conta);
            }

        }
    }
}
