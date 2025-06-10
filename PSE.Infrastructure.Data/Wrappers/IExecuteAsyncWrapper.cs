// Copyright (c) Creape. All Rights Reserved.

using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace PSE.Infrastructure.Data.Wrappers
{
    /// <summary>
    /// Interface para métodos do dapper
    /// </summary>
    public interface IExecuteAsyncWrapper
    {
        Task<int> ExecuteAsync(IDbConnection conn, string? query, object? data = null);
        Task<T> ExecuteScalarAsync<T>(IDbConnection conn, string? query, object? data = null);
        Task<IEnumerable<T>> QueryAsync<T>(IDbConnection conn, string? query, object? data = null) where T : class;
        Task<T> QueryFirstOrDefaultAsync<T>(IDbConnection conn, string? query, object? data = null) where T : class;
    }
}
