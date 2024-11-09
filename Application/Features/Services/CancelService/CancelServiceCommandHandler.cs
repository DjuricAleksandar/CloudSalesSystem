using Application.Dto;
using Application.Enums;
using MediatR;

namespace Application.Features.Services.CancelService;

internal class CancelServiceCommandHandler : IRequestHandler<CancelServiceCommand, IEnumerable<License>>
{
    public async Task<IEnumerable<License>> Handle(CancelServiceCommand request, CancellationToken cancellationToken)
    {
        return await Task.Run(() => new List<License>
        {
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = request.ServiceId,
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = request.ServiceId,
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = request.ServiceId,
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            }
        }, cancellationToken);
    }
}