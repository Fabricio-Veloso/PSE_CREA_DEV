// Copyright (c) Creape. All Rights Reserved.

using Microsoft.Extensions.DependencyInjection;
using PSE.Infrastructure.Data.Wrappers;

namespace PSE.Infrastructure.CrossCutting
{
    public static class HandlerInjectionBootStrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IExecuteAsyncWrapper, ExecuteAsyncWrapper>();            

            return services;
        }
    }
}
