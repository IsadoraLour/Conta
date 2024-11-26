using System.Collections.Generic;

namespace Conta
{
    public interface IContaPoupancaService 
    {
        void Adicionar(ContaPoupanca contaPoupanca);
        ContaPoupanca BuscarPorId(int id);
        void Editar(ContaPoupanca contaPoupanca);
        List<ContaPoupanca> Listar();
        void Remover(int id);
    }
}
