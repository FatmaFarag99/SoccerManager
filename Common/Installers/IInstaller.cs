namespace Common;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public interface IInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration);
}