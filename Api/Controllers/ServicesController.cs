using System.ComponentModel.DataAnnotations;
using Application.Features.Services.CancelService;
using Application.Features.Services.GetServices;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class ServicesController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await Mediator.Send(new GetServicesQuery()));
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Cancel([Required] CancelServiceCommand cancelServiceCommand)
    {
        return Ok(await Mediator.Send(cancelServiceCommand));
    }
}