using System;
using System.Collections.Generic;
using System.Linq;

namespace Conta
{
    public class ContaPoupancaService : IContaPoupancaService
    {
        private readonly IContaPoupancaRepository repositorio;

        public ContaPoupancaService(IContaPoupancaRepository repos)
        {
            repositorio = repos;
        }

        public void Adicionar(ContaPoupanca contaPoupanca)
        {
            repositorio.Adicionar(contaPoupanca);
        }

        public ContaPoupanca BuscarPorId(int id)
        {
            return repositorio.BuscarPorId(id);
        }

        public void Editar(ContaPoupanca contaPoupanca)
        {
            repositorio.Editar(contaPoupanca);
        }

        public List<ContaPoupanca> Listar()
        {
            return repositorio.Listar();
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }
    }
}
