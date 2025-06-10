// Copyright (c) Creape. All Rights Reserved.

using Microsoft.Extensions.Configuration;
using PSE.Domain.Interfaces.Conections;
using PSE.Domain.Interfaces.Factories;
using PSE.Domain.Settings;
using PSE.Infrastructure.Data.Wrappers;
using System.Data;
using Npgsql;

namespace PSE.Infrastructure.Data.Conections
{
    /// <summary>
    /// Classe para obter a conexão com o banco de dados
    /// </summary>
    public class PseDbConnection :
        DatabaseConnection,
        IPseDbConnection
    {
        /// <summary>
        /// Método para criar o conexao do banco de dados.
        /// </summary>
        /// <param name="configuration">configuration;</param>
        /// <param name="databaseConnectionWrapper">databaseConnectionWrapper.</param>
        public PseDbConnection(IConfiguration configuration, IDatabaseConnectionWrapper databaseConnectionWrapper)
            :base(configuration)
        {
            var dbSettings = new DbSettings();
            var dbPse = configuration.GetSection("PseDb");
            dbPse.Bind(dbSettings);
            dbSettings.DataBase = "PSE";
            string connectionString = dbSettings.GetConnectionString;
            this.connection = CreateConnection(connectionString);
        }

        /// <summary>
        ///  Criar a conexão com db.
        /// </summary>
        /// <param name="connectionString">String de conmex´~ao</param>
        /// <returns></returns>
        public override IDbConnection CreateConnection(string connectionString)
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
