using Domain.Entities;

namespace Domain.Interfaces;

public interface ICloudComputingProviderClient
{
    Task<IEnumerable<Service>> GetAvailableServices();

    Task<Guid> AcquireLicense(Guid serviceId);

    Task CancelLicense(Guid licenseId);
}