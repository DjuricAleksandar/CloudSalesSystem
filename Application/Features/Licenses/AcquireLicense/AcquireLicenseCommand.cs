using System.ComponentModel.DataAnnotations;
using Application.Dto;
using MediatR;

namespace Application.Features.Licenses.AcquireLicense;

public record AcquireLicenseCommand : IRequest<License>
{
    [Required]
    public Guid AccountId { get; set; }

    [Required]
    public Guid ServiceId { get; set; }
}