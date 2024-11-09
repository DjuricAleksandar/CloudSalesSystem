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

    public async Task<Guid> AcquireLicense(Guid serviceId)
    {
        await Task.Delay(1000);
        return new Guid();
    }

    public async Task CancelLicense(Guid licenseId)
    {
        await Task.Delay(1000);
    }
}