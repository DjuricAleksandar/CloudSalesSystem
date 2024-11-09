using Application.Dto;
using Application.Enums;
using MediatR;

namespace Application.Features.Licenses.GetLicenses;

internal class GetLicensesQueryHandler : IRequestHandler<GetLicensesQuery, IEnumerable<License>>
{
    public Task<IEnumerable<License>> Handle(GetLicensesQuery request, CancellationToken cancellationToken)
    {
        return Task.Run<IEnumerable<License>>(() =>
        [
            new License
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new License
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new License
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            }
        ], cancellationToken);
    }
}