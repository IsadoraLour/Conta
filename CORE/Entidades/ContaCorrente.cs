using System;

namespace Conta
{
    public class ContaCorrente : Conta
    {
        public double LimiteEspecial { get; private set; }
        public double TaxaManutencao { get; private set; }

        public ContaCorrente(string titular, double saldoInicial, double limiteEspecial, double taxaManutencao)
            : base(titular, saldoInicial)
        {
            LimiteEspecial = limiteEspecial;
            TaxaManutencao = taxaManutencao;
        }

        public override bool Sacar(double valor)
        {
            if (Saldo + LimiteEspecial >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"{Titular} sacou {valor:C}. Saldo atual: {Saldo:C} (Limite: {LimiteEspecial:C})");
                return true;
            }
            Console.WriteLine($"{Titular} tentou sacar {valor:C}, mas o saldo + limite especial é insuficiente.");
            return false;
        }

        public void CobrarTaxaManutencao()
        {
            if (Saldo >= TaxaManutencao)
            {
                Saldo -= TaxaManutencao;
                Console.WriteLine($"Taxa de manutenção de {TaxaManutencao:C} cobrada. Saldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine($"Não foi possível cobrar a taxa de manutenção de {TaxaManutencao:C}. Saldo insuficiente.");
            }
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo:C}");
            Console.WriteLine($"Limite Especial: {LimiteEspecial:C}");
            Console.WriteLine($"Taxa de Manutenção: {TaxaManutencao:C}");
        }
    }
}
