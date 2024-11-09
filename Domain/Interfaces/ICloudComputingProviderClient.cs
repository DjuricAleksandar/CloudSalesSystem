using Domain.Entities;

namespace Domain.Interfaces;

public interface ICloudComputingProviderClient
{
    Task<IEnumerable<Service>> GetAvailableServices();

    Task<(Guid licenceId, DateOnly validTo)> AcquireLicense(Guid serviceId);

    Task CancelLicense(Guid licenseId);
}