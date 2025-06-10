// Copyright (c) Creape. All Rights Reserved.

using PSE.Domain.Interfaces.Factories;
using System;

namespace PSE.Infrastructure.Data.Conections
{
    /// <summary>
    /// Classe reponsavel por gerencia o escopo de uma conexão com o banco de dados,
    /// Abre a conexão ao ser instanciada e a fecha ao ser descartada.
    /// </summary>
    public class PseDbConnectionScope: IDisposable
    {
        private readonly IPseDbConnection connection;

        /// <summary>
        /// Contrutor da classe <see cref="PseDbConnectionScope"/>
        /// </summary>
        /// <param name="connection"></param>
        public PseDbConnectionScope(IPseDbConnection connection)
        {
            this.connection = connection;
            this.connection.Open();
        }

        /// <summary>
        /// Get obtém a conexão com o banco de dados gerenciado por este escopo.
        /// </summary>
        public IPseDbConnection Connection => this.Connection;

        /// <summary>
        /// Fecha conexão com o bando de dados ao descartar esta instância.
        /// </summary>
        public void Dispose() 
        {
            this.connection.Close();
        }
    }
}
