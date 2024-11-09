using Application.Dto;
using MediatR;

namespace Application.Features.Accounts.GetAccounts;

public record GetAccountsQuery : IRequest<IEnumerable<Account>>;