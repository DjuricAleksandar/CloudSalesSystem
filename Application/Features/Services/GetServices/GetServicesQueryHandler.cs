using Application.Dto;
using AutoMapper;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Services.GetServices;

internal class GetServicesQueryHandler(IServicesRepository repository, IMapper mapper)
    : IRequestHandler<GetServicesQuery, IEnumerable<Service>>
{
    public async Task<IEnumerable<Service>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
    {
        var services = await repository.GetAll();
        var dtoServices = mapper.Map<IEnumerable<Service>>(services);
        return dtoServices;
    }
}