using Application.Dto;
using AutoMapper;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Licenses.CancelLicense;

internal class CancelLicenseCommandHandler(
    ICloudComputingProviderClient cloudComputingProvider,
    ILicensesRepository licensesRepository,
    IMapper mapper) : IRequestHandler<CancelLicenseCommand, License>
{
    public async Task<License> Handle(CancelLicenseCommand request, CancellationToken cancellationToken)
    {
        await cloudComputingProvider.CancelLicense(request.LicenceId);
        var license = await licensesRepository.CancelLicense(request.LicenceId);
        return mapper.Map<License>(license);
    }
}