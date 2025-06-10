// Copyright (c) Creape. All Rights Reserved.

using Microsoft.Extensions.Configuration;
using PSE.Domain.Settings;
using System;

namespace PSE.Infrastructure.Data.Wrappers
{
    /// <summary>
    /// Wrapper para centralizar e organizar melhor a logica de conexão.
    /// </summary>
    public class DatabaseConnectionWrapper : IDatabaseConnectionWrapper
    {
        public string GetConnectionString(IConfiguration configuration, DbSettings dbSettings, string secredName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            if (dbSettings == null)
            {
                throw new ArgumentNullException(nameof(dbSettings));
            }

            string connectionString = "Teste";

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Não foi possível obter o string da conexao");
            }

            return connectionString;
        }
    }
}
