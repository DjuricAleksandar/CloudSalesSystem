using Application.Dto;
using Application.Enums;
using MediatR;

namespace Application.Features.Services.CancelService;

internal class CancelServiceCommandHandler : IRequestHandler<CancelServiceCommand, IEnumerable<License>>
{
    public Task<IEnumerable<License>> Handle(CancelServiceCommand request, CancellationToken cancellationToken)
    {
        return Task.Run<IEnumerable<License>>(() =>
        [
            new License
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = request.ServiceId,
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new License
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = request.ServiceId,
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new License
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = request.ServiceId,
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            }
        ], cancellationToken);
    }
}