using Application.Dto;
using Application.Enums;
using MediatR;

namespace Application.Features.Licenses.CancelLicense;

internal class CancelLicenseCommandHandler : IRequestHandler<CancelLicenseCommand, License>
{
    public async Task<License> Handle(CancelLicenseCommand request, CancellationToken cancellationToken)
    {
        return await Task.Run(() => new License
        {
            Id = request.LicenceId,
            AccountId = Guid.NewGuid(),
            ServiceId = Guid.NewGuid(),
            State = States.Canceled,
            ValidTo = DateOnly.FromDayNumber(34)
        }, cancellationToken);
    }
}