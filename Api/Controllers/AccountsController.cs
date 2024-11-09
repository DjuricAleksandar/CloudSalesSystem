using Application.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class AccountsController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await Task.Run(() => new List<Account>
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
        }));
    }
}