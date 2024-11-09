﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class BaseApiController : ControllerBase
{
    private IMediator? _mediator;

    protected IMediator Mediator => (_mediator ??= HttpContext.RequestServices.GetService<IMediator>()) ?? throw new
        InvalidOperationException("Mediator service is not registered.");
}