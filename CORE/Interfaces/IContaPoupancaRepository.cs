using System.Collections.Generic;

namespace Conta
{
    public interface IContaPoupancaRepository 
    {
        void Adicionar(ContaPoupanca contaPoupanca);
        void Remover(int id);
        void Editar(ContaPoupanca contaPoupanca);
        List<ContaPoupanca> Listar();
        ContaPoupanca BuscarPorId(int id);


    }
}
