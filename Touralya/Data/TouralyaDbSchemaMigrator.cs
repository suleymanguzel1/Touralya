using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Touralya.Data;

public class TouralyaDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public TouralyaDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the TouralyaDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TouralyaDbContext>()
            .Database
            .MigrateAsync();

    }
}
