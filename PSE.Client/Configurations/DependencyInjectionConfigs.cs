// Copyright (c) Creape. All Rights Reserved.

using PSE.Infrastructure.CrossCutting;

namespace PSE.Client.Configurations
{
    public static class DependencyInjectionConfigs
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if(services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
           

            HandlerInjectionBootStrapper.RegisterServices(services);
        }
    }
}
