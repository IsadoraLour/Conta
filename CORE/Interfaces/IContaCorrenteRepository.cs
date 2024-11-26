using System.Collections.Generic;

namespace Conta
{
    public interface IContaCorrenteRepository 
    {
        void Adicionar(ContaCorrente contaCorrente);
        void Remover(int id);
        void Editar(ContaCorrente contaCorrente);
        List<ContaCorrente> Listar();
        ContaCorrente BuscarPorId(int id);
    }
}
