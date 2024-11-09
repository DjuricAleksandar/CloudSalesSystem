using Application.Dto;
using AutoMapper;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Licenses.ExtendLicense;

internal class ExtendLicenseCommandHandler(
    ICloudComputingProviderClient cloudComputingProvider,
    ILicensesRepository licensesRepository,
    IMapper mapper) : IRequestHandler<ExtendLicenseCommand, License>
{
    public async Task<License> Handle(ExtendLicenseCommand request, CancellationToken cancellationToken)
    {
        await cloudComputingProvider.ExtendLicense(request.LicenseId, request.ValidTo);
        var license = await licensesRepository.ExtendLicense(request.LicenseId, request.ValidTo);
        return mapper.Map<License>(license);
    }
}