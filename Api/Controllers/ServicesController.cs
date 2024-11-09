using System.ComponentModel.DataAnnotations;
using Application.Features.Services.CancelService;
using Application.Features.Services.GetServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class ServicesController(IMediator mediator) : BaseApiController(mediator)
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _mediator.Send(new GetServicesQuery()));
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Cancel([Required] CancelServiceCommand cancelServiceCommand)
    {
        return Ok(await _mediator.Send(cancelServiceCommand));
    }
}