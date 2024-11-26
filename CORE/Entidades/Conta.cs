using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public abstract class Conta : IConta

    {
        public string Titular { get; set; }
        public double Saldo { get; protected set; }
        public Conta(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }
        public virtual void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"{Titular} Depositou {valor:C} Saldo atual: {Saldo:C}");
        }
        public virtual bool Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"{Titular} Sacou {valor:C} Saldo atual: {Saldo:C}");
                return true;
            }
            Console.WriteLine($"{Titular} Tentou sacar {valor:C} saldo é insuficiente");
            return false;
        }
        public void Transferir(double valor, IConta contaDestino)
        {

            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
                Console.WriteLine($"{Titular} Transferiu {valor:C} para {((Conta)contaDestino).Titular}");
            }
        }
        public abstract void ExibirInformacoes();

    }
}

