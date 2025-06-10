// Copyright (c) Creape. All Rights Reserved.

using Microsoft.Extensions.Configuration;
using PSE.Domain.Settings;

namespace PSE.Infrastructure.Data.Wrappers
{
    /// <summary>
    /// Wrapper para centralizar e organizar melhor a logica de conexão.
    /// </summary>
    public interface IDatabaseConnectionWrapper
    {
        /// <summary>
        /// Obtém a string de conexão para o bancki de dados
        /// </summary>
        /// <param name="configuration">As configurações da aplicação</param>
        /// <param name="dbSettings">As configuraçõs especifica do banco</param>
        /// <param name="secredName">O nome do segredo da plicação tipo AWS </param>
        /// <returns></returns>
        string GetConnectionString(IConfiguration configuration, DbSettings dbSettings, string secredName);
    }
}
