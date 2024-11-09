using Domain.Entities;
using Domain.Interfaces;
using static Domain.Hardcoded;

namespace Infrastructure.Services;

internal class CloudComputingProviderClient : ICloudComputingProviderClient
{
    private static readonly IEnumerable<Service> Services =
    [
        new()
        {
            Id = ServiceId1,
            Name = "Service1"
        },
        new()
        {
            Id = ServiceId2,
            Name = "Service2"
        },
        new()
        {
            Id = ServiceId3,
            Name = "Service3"
        },
        new()
        {
            Id = ServiceId4,
            Name = "Service4"
        },
        new()
        {
            Id = ServiceId5,
            Name = "Service5"
        }
    ];

    public async Task<IEnumerable<Service>> GetAvailableServices()
    {
        await Task.Delay(1000);
        return Services;
    }

    public async Task<(Guid licenceId, DateOnly validTo)> AcquireLicense(Guid serviceId)
    {
        await Task.Delay(1000);
        if (Services.All(s => s.Id != serviceId))
            throw new InvalidOperationException("Service is not available.");

        return (new Guid(), DateOnly.FromDateTime(DateTime.Now.AddYears(1)));
    }

    public async Task CancelLicense(Guid licenseId)
    {
        await Task.Delay(1000);
    }

    public async Task ExtendLicense(Guid licenseId, DateOnly validTo)
    {
        await Task.Delay(1000);
    }
}