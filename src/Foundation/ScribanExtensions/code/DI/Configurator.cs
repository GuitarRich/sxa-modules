using Foundation.ScribanExtensions.Cache;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Foundation.ScribanExtensions.DI
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IScribanRenderCache, ScribanRenderCache>();
        }
    }
}
