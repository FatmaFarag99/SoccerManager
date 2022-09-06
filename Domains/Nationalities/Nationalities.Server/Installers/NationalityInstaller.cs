namespace Nationalities.Server;

using Common.AssemplyScanning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class NationalityInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<NationalityViewModel>, NationalityValidator>();
        services.AddScoped<INationalityRepository, NationalityRepository>();
        services.AddScoped<INationalityUnitOfWork, NationalityUnitOfWork>();
    }
}
