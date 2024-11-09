using Application.Dto;
using AutoMapper;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Accounts.GetAccounts;

internal class GetAccountsQueryHandler(IAccountsRepository repository, IMapper mapper)
    : IRequestHandler<GetAccountsQuery, IEnumerable<Account>>
{
    public async Task<IEnumerable<Account>> Handle(GetAccountsQuery request, CancellationToken cancellationToken)
    {
        var accounts = await repository.GetAll();
        var dtoAccounts = mapper.Map<IEnumerable<Account>>(accounts);
        return dtoAccounts;
    }
}