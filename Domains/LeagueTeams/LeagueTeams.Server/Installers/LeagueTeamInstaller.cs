namespace LeagueTeams.Server;

using Common.AssemplyScanning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class LeagueTeamInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<LeagueTeamViewModel>, LeagueTeamValidator>();
        services.AddScoped<ILeagueTeamRepository, LeagueTeamRepository>();
        services.AddScoped<ILeagueTeamUnitOfWork, LeagueTeamUnitOfWork>();
    }
}
