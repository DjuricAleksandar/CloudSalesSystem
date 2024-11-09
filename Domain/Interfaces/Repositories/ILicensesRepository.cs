using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface ILicensesRepository : IGenericRepository<License>
{
    Task<License> CancelLicense(Guid licenseId);
}