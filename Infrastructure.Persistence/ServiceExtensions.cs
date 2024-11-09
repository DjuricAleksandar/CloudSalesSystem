using Domain.Interfaces.Repositories;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence;

public static class ServiceExtensions
{
    public static void AddPersistenceLayer(this IServiceCollection services)
    {
        services.AddDbContext<CloudSalesDbContext>(o => o.UseInMemoryDatabase("CloudSalesDb"));
        services.AddTransient<IAccountsRepository, AccountsRepository>();
        services.AddTransient<IServicesRepository, ServicesRepository>();
        services.AddTransient<ILicensesRepository, LicensesRepository>();
    }
}