using Application.Dto;
using Application.Enums;
using MediatR;

namespace Application.Features.Licenses.GetLicenses;

internal class GetLicensesQueryHandler : IRequestHandler<GetLicensesQuery, IEnumerable<License>>
{
    public async Task<IEnumerable<License>> Handle(GetLicensesQuery request, CancellationToken cancellationToken)
    {
        return await Task.Run(() => new List<License>
        {
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            }
        }, cancellationToken);
    }
}