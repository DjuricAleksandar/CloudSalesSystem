﻿using Application.Dto;
using MediatR;

namespace Application.Features.GetAccounts;

internal class GetAccountsHandler : IRequestHandler<GetAccounts, IEnumerable<Account>>
{
    public async Task<IEnumerable<Account>> Handle(GetAccounts request, CancellationToken cancellationToken)
    {
        return await Task.Run(() => new List<Account>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Account1"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Account2"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Account3"
            }
        }, cancellationToken);
    }
}