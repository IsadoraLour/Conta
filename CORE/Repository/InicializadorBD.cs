using Dapper;
using System.Data.SQLite;

namespace Dominio._02_Repository
{
    public static class InicializadorBD
    {
        private const string ConnectionString = "Data Source=BancoContas.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string comandoSQL = @"
                    CREATE TABLE IF NOT EXISTS ContasCorrente (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Titular TEXT NOT NULL,
                        Saldo REAL NOT NULL,
                        LimiteChequeEspecial REAL NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS ContasPoupanca (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Titular TEXT NOT NULL,
                        Saldo REAL NOT NULL,
                        TaxaRendimento REAL NOT NULL
                    );
                ";

                connection.Execute(comandoSQL);
            }
        }
    }
}
