using Conta;
using Dominio._03_Service.Interfaces;

namespace Dominio._03_Service
{
    public class ContaCorrenteService : IContaCorrenteService
    {
        private readonly IContaCorrenteRepository repositorio;

        public ContaCorrenteService(IContaCorrenteRepository repos)
        {
            repositorio = repos;
        }

        public void Adicionar(ContaCorrente contaCorrente)
        {
            repositorio.Adicionar(contaCorrente);
        }

        public ContaCorrente BuscarPorId(int id)
        {
            return repositorio.BuscarPorId(id);
        }

        public void Editar(ContaCorrente contaCorrente)
        {
            repositorio.Editar(contaCorrente);
        }

        public List<ContaCorrente> Listar()
        {
            return repositorio.Listar();
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }
    }
}