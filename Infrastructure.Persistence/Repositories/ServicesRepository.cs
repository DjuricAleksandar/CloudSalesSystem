using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Persistence.Contexts;

namespace Infrastructure.Persistence.Repositories;

internal class ServicesRepository(CloudSalesDbContext cloudSalesDbContext)
    : GenericRepository<Service>(cloudSalesDbContext), IServicesRepository;