using System;

namespace Conta
{
    public class ContaPoupanca : Conta
    {
        public double TaxaRendimento { get; private set; }

        public ContaPoupanca(string titular, double saldoInicial, double taxaRendimento)
            : base(titular, saldoInicial)
        {
            TaxaRendimento = taxaRendimento;
        }

        public void CalcularRendimento()
        {
            double rendimento = Saldo * TaxaRendimento;
            Saldo += rendimento;
            Console.WriteLine($"{Titular} recebeu um rendimento de {rendimento:C}. Saldo atual: {Saldo:C}");
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo:C}");
            Console.WriteLine($"Taxa de Rendimento: {TaxaRendimento:P}");
        }
    }
}
