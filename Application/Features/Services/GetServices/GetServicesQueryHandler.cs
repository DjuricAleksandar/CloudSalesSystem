using Application.Dto;
using MediatR;

namespace Application.Features.Services.GetServices;

internal class GetServicesQueryHandler : IRequestHandler<GetServicesQuery, IEnumerable<Service>>
{
    public Task<IEnumerable<Service>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
    {
        return Task.Run<IEnumerable<Service>>(() =>
        [
            new Service
            {
                Id = Guid.NewGuid(),
                Name = "Service1"
            },
            new Service
            {
                Id = Guid.NewGuid(),
                Name = "Service2"
            },
            new Service
            {
                Id = Guid.NewGuid(),
                Name = "Service3"
            }
        ], cancellationToken);
    }
}