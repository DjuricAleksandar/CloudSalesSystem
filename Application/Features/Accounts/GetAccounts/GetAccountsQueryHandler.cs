using Application.Dto;
using MediatR;

namespace Application.Features.Accounts.GetAccounts;

internal class GetAccountsQueryHandler : IRequestHandler<GetAccountsQuery, IEnumerable<Account>>
{
    public Task<IEnumerable<Account>> Handle(GetAccountsQuery request, CancellationToken cancellationToken)
    {
        return Task.Run<IEnumerable<Account>>(() =>
        [
            new Account
            {
                Id = Guid.NewGuid(),
                Name = "Account1"
            },
            new Account
            {
                Id = Guid.NewGuid(),
                Name = "Account2"
            },
            new Account
            {
                Id = Guid.NewGuid(),
                Name = "Account3"
            }
        ], cancellationToken);
    }
}