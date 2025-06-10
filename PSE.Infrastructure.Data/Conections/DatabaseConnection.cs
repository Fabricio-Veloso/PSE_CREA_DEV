// Copyright (c) Creape. All Rights Reserved.

using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace PSE.Domain.Interfaces.Conections
{
    /// <summary>
    /// Classe abstrata para concexao com o banco de dados
    /// </summary>
    public abstract class DatabaseConnection : IDisposable
    {
        private readonly IConfiguration configuration;
        protected IDbConnection connection;

        /// <summary>
        /// Contruto da classe.
        /// </summary>
        /// <param name="configuration">configuration.</param>
        protected DatabaseConnection(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Gets or set ConnectionString.
        /// </summary>
        public string ConnectionString
        {
            get => this.connection?.ConnectionString ?? string.Empty;
            set => this.connection.ConnectionString = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Gets ConnectionTimeout.
        /// </summary>
        public int ConnectionTimeout => this.connection.ConnectionTimeout;

        /// <summary>
        /// Gets noem do banco de dados.
        /// </summary>
        public string Database => this.connection.Database;

        /// <summary>
        /// Gets estado da conexao.
        /// </summary>
        public ConnectionState State => this.connection.State;

        /// <summary>
        /// Gets Iniciao da concexao.
        /// </summary>
        public IDbTransaction BeginTransaction() => this.connection.BeginTransaction();

        /// <summary>
        /// Gets Iniciao da Transação.
        /// </summary>
        public IDbTransaction BeginTransaction(IsolationLevel il) => this.connection.BeginTransaction(il);

        /// <summary>
        /// Gets Muda de banco de dados.
        /// </summary>
        public void ChangeDatabase(string databaseName) => this.connection.ChangeDatabase(databaseName);

        /// <summary>
        /// Gets Criação do command.
        /// </summary>
        public IDbCommand CreateCommand() => this.connection.CreateCommand();

        /// <summary>
        /// Gets Fecha conexão com o banco de dados.
        /// </summary>
        public void Close() => this.connection.Close();

        /// <summary>
        /// Gets Abre conexão com o banco de dados.
        /// </summary>
        public void Open() => this.connection.Open();

        /// <summary>
        /// Gets Encerra conexão com o banco de dados.
        /// </summary>
        public void Dispose() => this.connection.Dispose();

        /// <summary>
        /// Gets Criar conexão com o banco de dados.
        /// </summary>
        public abstract IDbConnection CreateConnection(string connectionString);
    }
}
