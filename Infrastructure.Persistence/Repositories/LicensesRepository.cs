using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Persistence.Contexts;

namespace Infrastructure.Persistence.Repositories;

internal class LicensesRepository(CloudSalesDbContext cloudSalesDbContext)
    : GenericRepository<License>(cloudSalesDbContext), ILicensesRepository;