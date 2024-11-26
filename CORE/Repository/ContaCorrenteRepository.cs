using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Conta
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        private readonly string ConnectionString;
        public ContaCorrenteRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(ContaCorrente contaCorrente)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<ContaCorrente>(contaCorrente);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaCorrente contaCorrente = BuscarPorId(id);
            connection.Delete<ContaCorrente>(contaCorrente);
        }
        public void Editar(ContaCorrente contaCorrente)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<ContaCorrente>(contaCorrente);
        }
        public List<ContaCorrente> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaCorrente>().ToList();
        }
        public ContaCorrente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaCorrente>(id);
        }
    }
}