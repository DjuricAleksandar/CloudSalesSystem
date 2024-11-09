using System.ComponentModel.DataAnnotations;
using Application.Dto;
using Application.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class ServicesController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await Task.Run(() => new List<Service>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Service1"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Service2"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Service3"
            }
        }));
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Cancel([Required] Guid serviceId)
    {
        return Ok(await Task.Run(() => new List<Licence>
        {
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            },
            new()
            {
                Id = Guid.NewGuid(),
                AccountId = Guid.NewGuid(),
                ServiceId = Guid.NewGuid(),
                State = States.Canceled,
                ValidTo = DateOnly.FromDayNumber(34)
            }
        }));
    }
}