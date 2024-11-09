using System.ComponentModel.DataAnnotations;
using Application.Features.Licenses.AcquireLicense;
using Application.Features.Licenses.CancelLicense;
using Application.Features.Licenses.ExtendLicense;
using Application.Features.Licenses.GetLicenses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class LicensesController(IMediator mediator) : BaseApiController(mediator)
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _mediator.Send(new GetLicensesQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Post([Required] AcquireLicenseCommand acquireLicenseCommand)
    {
        return Ok(await _mediator.Send(acquireLicenseCommand));
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Cancel([Required] CancelLicenseCommand cancelLicenseCommand)
    {
        return Ok(await _mediator.Send(cancelLicenseCommand));
    }

    [HttpPatch("[action]")]
    public async Task<IActionResult> Extend([Required] ExtendLicenseCommand extendLicenseCommand)
    {
        return Ok(await _mediator.Send(extendLicenseCommand));
    }
}