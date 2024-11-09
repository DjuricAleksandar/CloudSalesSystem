using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Services;

public static class ServiceExtensions
{
    public static void AddServicesLayer(this IServiceCollection services)
    {
        services.AddTransient<ICloudComputingProviderClient, CloudComputingProviderClient>();
    }
}