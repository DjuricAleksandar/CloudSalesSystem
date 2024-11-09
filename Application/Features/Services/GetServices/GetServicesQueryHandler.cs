using Application.Dto;
using MediatR;

namespace Application.Features.Services.GetServices;

internal class GetServicesQueryHandler : IRequestHandler<GetServicesQuery, IEnumerable<Service>>
{
    public async Task<IEnumerable<Service>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
    {
        return await Task.Run(() => new List<Service>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Service1"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Service2"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Service3"
            }
        }, cancellationToken);
    }
}