using System.Reflection;
using Scan_Product_TTTQ.Application.Common.Context;
using Scan_Product_TTTQ.Domain.Abstractions;
using Scan_Product_TTTQ.Infrastructure.Data;
using Scan_Product_TTTQ.Infrastructure.Middleware;
using Scan_Product_TTTQ.Infrastructure.Repositories;
using Scan_Product_TTTQ.Infrastructure.Validations;
using Dapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Scan_Product_TTTQ.Domain.Abstractions;
using Infrastructure.Repositories;
using Infrastructure.Services;

namespace Scan_Product_TTTQ.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString =
            configuration.GetConnectionString("DBConnection") ??
            throw new ArgumentNullException(nameof(configuration));

        SqlMapper.AddTypeHandler(new DateOnlyHandler());
        SqlMapper.AddTypeHandler(new TimeOnlyHandler());
        SqlMapper.AddTypeHandler(new GuidHandler());

        var applicationAssembly = typeof(Scan_Product_TTTQ.Application.DependencyInjection).GetTypeInfo().Assembly;

        services.AddTransient<IUnitOfWork, DapperUnitOfWork>(c => new DapperUnitOfWork(connectionString))
            .AddSingleton(new MySqlConnectionFactory(connectionString))
            .AddScoped<ExceptionMiddleware>()
            .AddBehaviours(applicationAssembly)
            .AddRepositories()
            .AddServices();


        return services;
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app, IConfiguration config)
    {
        app.UseExceptionMiddleware();
        return app;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        // Register repositories using reflection based on naming convention
        var repositoryTypes = Assembly
            .GetAssembly(
                typeof(UserRepository)) // Assuming SubjectRepository is representative of the assembly containing all repositories
            ?.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Repository"))
            .ToList();

        foreach (var type in repositoryTypes)
        {
            var interfaceType = type.GetInterfaces().FirstOrDefault(i => i.Name == "I" + type.Name);
            if (interfaceType != null)
            {
                services.AddScoped(interfaceType, type);
            }
        }

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        // Register services using reflection based on naming convention
        var serviceTypes = Assembly
            .GetAssembly(
                typeof(TokenService)) // Assuming TokenService is representative of the assembly containing all services
            ?.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Service"))
            .ToList();

        foreach (var type in serviceTypes)
        {
            var interfaceType = type.GetInterfaces().FirstOrDefault(i => i.Name == "I" + type.Name);
            if (interfaceType != null)
            {
                services.AddScoped(interfaceType, type);
            }
        }

        return services;
    }

}