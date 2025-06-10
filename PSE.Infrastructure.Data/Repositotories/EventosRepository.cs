// Copyright (c) Creape. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using PSE.Domain.Interfaces.Factories;
using PSE.Domain.Interfaces.Repositories;
using PSE.Domain.Model;
using PSE.Infrastructure.Data.Conections;
using PSE.Infrastructure.Data.Wrappers;

namespace PSE.Infrastructure.Data.Repositotories
{
    public class EventosRepository : IEventosRepository
    {
        private readonly IExecuteAsyncWrapper executeAsyncWrapper;
        private readonly IPseDbConnection pseDbConnection;

        public EventosRepository(
            IExecuteAsyncWrapper executeAsyncWrapper,
            IPseDbConnection pseDbConnection)
        {
            this.executeAsyncWrapper = executeAsyncWrapper;
            this.pseDbConnection = pseDbConnection;
        }


        public async Task<IEnumerable<Eventos>> ListAsycn()
        {
            try
            {
                // Query Templete
                string sqlTemplate = @"SELECT   id as Id, 
                                                nome as Nome, 
                                                descricao as Descricao, 
                                                duracao as Duracao,
                                                vagas_totais as VagasTotais,
                                                start_evento as StartEvento 
                                                FROM ""Cursos"".""TB_Eventos"";";

                var sqlBuilder = new SqlBuilder();

                var template = sqlBuilder.AddTemplate(sqlTemplate);

                var parameter = new DynamicParameters();

                using (var scope = new PseDbConnectionScope(this.pseDbConnection))
                {
                    var data = await this.executeAsyncWrapper.QueryAsync<Eventos>(this.pseDbConnection, template.RawSql, null);
                    return data;
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
