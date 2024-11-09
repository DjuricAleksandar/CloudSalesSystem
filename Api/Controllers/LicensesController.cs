using System.ComponentModel.DataAnnotations;
using Application.Features.Licenses.AcquireLicense;
using Application.Features.Licenses.CancelLicense;
using Application.Features.Licenses.ExtendLicense;
using Application.Features.Licenses.GetLicenses;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class LicensesController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await Mediator.Send(new GetLicensesQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Post([Required] AcquireLicenseCommand acquireLicenseCommand)
    {
        return Ok(await Mediator.Send(acquireLicenseCommand));
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Cancel([Required] CancelLicenseCommand cancelLicenseCommand)
    {
        return Ok(await Mediator.Send(cancelLicenseCommand));
    }

    [HttpPatch("[action]")]
    public async Task<IActionResult> Extend([Required] ExtendLicenseCommand extendLicenseCommand)
    {
        return Ok(await Mediator.Send(extendLicenseCommand));
    }
}