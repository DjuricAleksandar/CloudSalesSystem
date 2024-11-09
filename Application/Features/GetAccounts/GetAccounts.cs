using Application.Dto;
using MediatR;

namespace Application.Features.GetAccounts;

public record GetAccounts : IRequest<IEnumerable<Account>>;