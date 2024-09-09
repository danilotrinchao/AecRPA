using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace AluraRPA.Infra.Data.Context
{
    public class DbContext: IDbContext
    {
        private readonly IDbConnection _connection;

        public DbContext(IOptions<ConnectionStringOptions> databaseConfig)
        {
            //connection = new SqlConnection(databaseConfig.Value.ConnectionString);
            _connection.Open();
        }

        public IDbConnection Connection => _connection;

        public void Dispose()
        {
            if (_connection.State != ConnectionState.Closed)
                _connection.Close();
        }

    }
}
