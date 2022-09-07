namespace Common;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public abstract class Installer : IInstaller
{
    public abstract void Install(IServiceCollection services, IConfiguration configuration);
    public static async Task Use(WebApplication application)
    {

    }
}