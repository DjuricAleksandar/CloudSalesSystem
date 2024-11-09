using System.ComponentModel.DataAnnotations;
using Application.Dto;
using Application.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class LicencesController : BaseApiController
{
    [HttpPost]
    public async Task<IActionResult> Post([Required] Guid accountId, [Required] Guid serviceId)
    {
        return Ok(await Task.Run(() => new Licence
        {
            Id = Guid.NewGuid(),
            AccountId = accountId,
            ServiceId = serviceId,
            State = States.Active,
            ValidTo = DateOnly.FromDayNumber(34)
        }));
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