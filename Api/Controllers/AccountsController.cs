using Application.Features.Accounts.GetAccounts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class AccountsController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await Mediator.Send(new GetAccountsQuery()));
    }
}