using Application.Dto;
using Application.Enums;
using MediatR;

namespace Application.Features.Licenses.ExtendLicense;

internal class ExtendLicenseCommandHandler : IRequestHandler<ExtendLicenseCommand, License>
{
    public Task<License> Handle(ExtendLicenseCommand request, CancellationToken cancellationToken)
    {
        return Task.Run(() => new License
        {
            Id = request.LicenceId,
            AccountId = Guid.NewGuid(),
            ServiceId = Guid.NewGuid(),
            State = States.Active,
            ValidTo = request.ValidTo
        }, cancellationToken);
    }
}