using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Conta
{
    public class ContaPoupancaRepository : IContaPoupancaRepository
    {
        private readonly string ConnectionString;
        public ContaPoupancaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(ContaPoupanca contaPoupanca)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<ContaPoupanca>(contaPoupanca);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaPoupanca contaPoupanca = BuscarPorId(id);
            connection.Delete<ContaPoupanca>(contaPoupanca);
        }
        public void Editar(ContaPoupanca contaPoupanca)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<ContaPoupanca>(contaPoupanca);
        }
        public List<ContaPoupanca> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaPoupanca>().ToList();
        }
        public ContaPoupanca BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaPoupanca>(id);
        }
    }
}