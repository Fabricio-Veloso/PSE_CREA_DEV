// Copyright (c) Creape. All Rights Reserved.

using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace PSE.Infrastructure.Data.Wrappers
{
    /// <summary>
    /// classe para métodos do dapper
    /// </summary>
    public class ExecuteAsyncWrapper : IExecuteAsyncWrapper
    {
        public async Task<int> ExecuteAsync(IDbConnection conn, string query, object data = null) => await conn.ExecuteAsync(query, data);        

        public async Task<T> ExecuteScalarAsync<T>(IDbConnection conn, string query, object data = null) => await conn.ExecuteScalarAsync<T>(query, data);
        
        public async Task<IEnumerable<T>> QueryAsync<T>(IDbConnection conn, string query, object data = null) 
            where T : class => await conn.QueryAsync<T>(query, data);        

        public async Task<T> QueryFirstOrDefaultAsync<T>(IDbConnection conn, string query, object data = null) 
            where T : class => await conn.QueryFirstOrDefaultAsync<T>(query, data);        
    }
}
