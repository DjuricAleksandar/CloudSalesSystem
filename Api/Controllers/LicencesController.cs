using System.ComponentModel.DataAnnotations;
using Application.Dto;
using Application.Enums;
using Application.Features.Licences.AcquireLicence;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class LicencesController : BaseApiController
{
    [HttpPost]
    public async Task<IActionResult> Post([Required] AcquireLicenceCommand acquireLicenceCommand)
    {
        return Ok(await Mediator.Send(acquireLicenceCommand));
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await Task.Run(() => new List<Licence>
        {
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Active,
                ValidTo = DateOnly.FromDayNumber(34)
            }
        }));
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Cancel([Required] Guid licenceId)
    {
        return Ok(await Task.Run(() => new Licence
        {
            Id = licenceId,
            AccountId = Guid.NewGuid(),
            ServiceId = Guid.NewGuid(),
            State = States.Canceled,
            ValidTo = DateOnly.FromDayNumber(34)
        }));
    }

    [HttpPatch("[action]")]
    public async Task<IActionResult> Extend([Required] Guid licenceId, [Required] DateOnly validTo)
    {
        return Ok(await Task.Run(() => new Licence
        {
            Id = licenceId,
            AccountId = Guid.NewGuid(),
            ServiceId = Guid.NewGuid(),
            State = States.Active,
            ValidTo = validTo
        }));
    }
}