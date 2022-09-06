namespace Coaches.Server;

using Common.AssemplyScanning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class CoachInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IValidator<CoachViewModel>, CoachValidator>();
        services.AddScoped<ICoachRepository, CoachRepository>();
        services.AddScoped<ICoachUnitOfWork, CoachUnitOfWork>();
    }
}
