using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public class ContaCorrente : Conta

    {
        public double LimiteDeCredito { get; set; }
        public ContaCorrente(string titular, double saldoInicial, double limiteDeCredito)
            : base(titular, saldoInicial)
        {
            LimiteDeCredito = limiteDeCredito;
        }
        public override bool Sacar(double valor)
        {
            if (Saldo + LimiteDeCredito >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"{Titular} sacou {valor:C} limite de crédito: {Saldo:C}");
                return true;
            }
            Console.WriteLine($"{Titular} tentou sacar {valor:C} passou do saldo.");
            return false;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Conta Corrente: {Titular} Saldo: {Saldo:C} Limite de Crédito: {LimiteDeCredito:C}");
        }
    }

}
