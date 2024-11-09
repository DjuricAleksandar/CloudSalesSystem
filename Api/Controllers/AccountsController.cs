using Application.Features.Accounts.GetAccounts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class AccountsController(IMediator mediator) : BaseApiController(mediator)
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _mediator.Send(new GetAccountsQuery()));
    }
}