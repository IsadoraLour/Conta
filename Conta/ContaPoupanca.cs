using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public class ContaPoupanca : Conta

    {
        public double TaxaeJuros { get; set; }
        public ContaPoupanca(string titular, double saldoInicial, double taxaDeJuros)
            : base(titular, saldoInicial)
        {
            TaxaeJuros = taxaDeJuros;
        }
        public override void Depositar(double valor)
        {
            double rendimento = valor * TaxaeJuros / 100;
            Saldo += valor + rendimento;
            Console.WriteLine($"{Titular} depositou na conta {valor:C} com rendimento de {rendimento:C} Saldo atual: {Saldo:C}");
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Conta Poupança: {Titular} Saldo: {Saldo:C} Taxa e Juros: {TaxaeJuros}%");
        }
    }
}
