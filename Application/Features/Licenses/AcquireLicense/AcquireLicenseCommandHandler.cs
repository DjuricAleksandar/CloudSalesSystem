using Application.Dto;
using AutoMapper;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Licenses.AcquireLicense;

internal class AcquireLicenseCommandHandler(
    ICloudComputingProviderClient cloudComputingProvider,
    ILicensesRepository licensesRepository,
    IMapper mapper) : IRequestHandler<AcquireLicenseCommand, License>
{
    public async Task<License> Handle(AcquireLicenseCommand request, CancellationToken cancellationToken)
    {
        var (licenceId, validTo) = await cloudComputingProvider.AcquireLicense(request.ServiceId);
        var license = await licensesRepository.Add(new Domain.Entities.License
        {
            AccountId = request.AccountId,
            Id = licenceId,
            ServiceId = request.ServiceId,
            ValidTo = validTo,
            State = States.Active
        });
        return mapper.Map<License>(license);
    }
}