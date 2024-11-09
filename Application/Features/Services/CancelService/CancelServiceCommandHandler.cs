using Application.Dto;
using AutoMapper;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Services.CancelService;

internal class CancelServiceCommandHandler(
    ILicensesRepository licensesRepository,
    ICloudComputingProviderClient cloudComputingProvider,
    IMapper mapper) : IRequestHandler<CancelServiceCommand, IEnumerable<License>>
{
    public async Task<IEnumerable<License>> Handle(CancelServiceCommand request, CancellationToken cancellationToken)
    {
        var allLicenses = await licensesRepository.GetAll();
        var licensesToCancel = allLicenses.Where(l => l.ServiceId == request.ServiceId).ToList();
        var result = new List<License>();
        foreach (var license in licensesToCancel)
        {
            await cloudComputingProvider.CancelLicense(license.Id);
            var canceledLicense = await licensesRepository.CancelLicense(license.Id);
            result.Add(mapper.Map<License>(canceledLicense));
        }

        return result;
    }
}