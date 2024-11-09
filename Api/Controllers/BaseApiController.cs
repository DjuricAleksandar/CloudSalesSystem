using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class BaseApiController(IMediator mediator) : ControllerBase
{
    protected readonly IMediator _mediator = mediator;
}