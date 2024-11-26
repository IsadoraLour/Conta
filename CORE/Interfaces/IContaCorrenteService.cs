using Conta;

namespace Dominio._03_Service.Interfaces
{
    public interface IContaCorrenteService
    {
        void Adicionar(ContaCorrente contaCorrente);
        ContaCorrente BuscarPorId(int id);
        void Editar(ContaCorrente contaCorrente);
        List<ContaCorrente> Listar();
        void Remover(int id);
    }
}
