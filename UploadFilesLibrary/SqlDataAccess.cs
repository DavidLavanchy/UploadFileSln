﻿

using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace UploadFilesLibrary
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task SaveData(
            string storedProcedure,
            string connectionName,
            object parameters)
        {
            string connectionString = _config.GetConnectionString(connectionName)
                ?? throw new Exception($"Missing connection string {connectionName}");

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync(
                storedProcedure,
                parameters,
                commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}