namespace SoccerManager.Installers
{
    using Common;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.OpenApi.Models;

    public class SwaggerInstaller : Installer
    {
        public override void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ResumeCreator",
                    Description = "The Best Resume Maker Online."
                });

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            });
        }

        public static new async Task Use(WebApplication application)
        {
            application.UseSwagger();
            application.UseSwaggerUI();
        }
    }
}