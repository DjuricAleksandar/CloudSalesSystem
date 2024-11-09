using Application.Dto;
using Application.Enums;
using MediatR;

namespace Application.Features.Licences.AcquireLicence;

internal class AcquireLicenceCommandHandler : IRequestHandler<AcquireLicenceCommand, Licence>
{
    public async Task<Licence> Handle(AcquireLicenceCommand request, CancellationToken cancellationToken)
    {
        return await Task.Run(() => new Licence
        {
            Id = Guid.NewGuid(),
            AccountId = request.AccountId,
            ServiceId = request.ServiceId,
            State = States.Active,
            ValidTo = DateOnly.FromDayNumber(34)
        }, cancellationToken);
    }
}