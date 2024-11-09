using Application.Dto;
using AutoMapper;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Services.GetServices;

internal class GetServicesQueryHandler(ICloudComputingProviderClient cloudComputingProvider, IMapper mapper)
    : IRequestHandler<GetServicesQuery, IEnumerable<Service>>
{
    public async Task<IEnumerable<Service>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
    {
        var services = await cloudComputingProvider.GetAvailableServices();
        var dtoServices = mapper.Map<IEnumerable<Service>>(services);
        return dtoServices;
    }
}