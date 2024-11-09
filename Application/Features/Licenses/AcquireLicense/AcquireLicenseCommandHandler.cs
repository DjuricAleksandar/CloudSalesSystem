﻿using Application.Dto;
using Application.Enums;
using MediatR;

namespace Application.Features.Licenses.AcquireLicense;

internal class AcquireLicenseCommandHandler : IRequestHandler<AcquireLicenseCommand, License>
{
    public Task<License> Handle(AcquireLicenseCommand request, CancellationToken cancellationToken)
    {
        return Task.Run(() => new License
        {
            Id = Guid.NewGuid(),
            AccountId = request.AccountId,
            ServiceId = request.ServiceId,
            State = States.Active,
            ValidTo = DateOnly.FromDayNumber(34)
        }, cancellationToken);
    }
}