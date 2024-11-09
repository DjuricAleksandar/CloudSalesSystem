using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Repositories;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

internal class LicensesRepository(CloudSalesDbContext cloudSalesDbContext)
    : GenericRepository<License>(cloudSalesDbContext), ILicensesRepository
{
    public async Task<License> CancelLicense(Guid licenseId)
    {
        var license = await DbContext.Licenses.FirstAsync(l => l.Id == licenseId);
        license.State = States.Canceled;
        await DbContext.SaveChangesAsync();
        return license;
    }

    public async Task<License> ExtendLicense(Guid licenseId, DateOnly validTo)
    {
        var license = await DbContext.Licenses.FirstAsync(l => l.Id == licenseId);
        license.ValidTo = validTo;
        await DbContext.SaveChangesAsync();
        return license;
    }
}