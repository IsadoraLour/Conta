using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public class GestaoContas
    {
        private List<IConta> contas = new List<IConta>();
        public void AdicionarConta(IConta conta)
        {
            contas.Add(conta);
            Console.WriteLine($"Conta de {((Conta)conta).Titular} Concluida");
        }
        public void ExibirContas()
        {
            Console.WriteLine("Contas Cadastradas:");
            foreach (var conta in contas)
            {
                conta.ExibirInformacoes();
            }
        }
        public void RealizarTransferencia(string titularOrigem, string titularDestino, double valor)
        {
            var contaOrigem = contas.Find(c => ((Conta)c).Titular == titularOrigem);
            var contaDestino = contas.Find(c => ((Conta)c).Titular == titularDestino);
            if (contaOrigem != null && contaDestino != null)
            {
                contaOrigem.Transferir(valor, contaDestino);
            }
            else
            {
                Console.WriteLine("Transferência não realizada");
            }
        }
    }
}
