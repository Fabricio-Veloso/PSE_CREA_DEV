// Copyright (c) Creape. All Rights Reserved.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PSE.Domain.Interfaces.Factories;
using PSE.Domain.Interfaces.Repositories;
using PSE.Domain.Settings;
using PSE.Infrastructure.Data.Conections;
using PSE.Infrastructure.Data.Repositotories;
using PSE.Infrastructure.Data.Wrappers;

namespace PSE.Infrastructure.CrossCutting
{
    /// <summary>
    /// Configuração para injeção de dependencias para acesso de dados
    /// </summary>
    public static class ConsumerDbConfiguration
    {
        public static IServiceCollection AddConsumerConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var dbSettings = new DbSettings();
            var dbPse = configuration.GetSection("PseDb");
            dbPse.Bind(dbSettings);
            
            services.AddRepositoriesPSe();
            return services;
        }

        public static IServiceCollection AddRepositoriesPSe(this IServiceCollection services)
        {
            services.AddTransient<IPseDbConnection>(sp =>
            {
                var configuration = sp.GetRequiredService<IConfiguration>();
                var databaseConnectionWrapper = sp.GetRequiredService<IDatabaseConnectionWrapper>();
                return new PseDbConnection(configuration, databaseConnectionWrapper);
            });

            services.AddTransient<IDatabaseConnectionWrapper, DatabaseConnectionWrapper>();
            services.AddScoped<IExecuteAsyncWrapper, ExecuteAsyncWrapper>();
            services.AddScoped<IEventosRepository, EventosRepository>();

            return services;
        }
    }
}
