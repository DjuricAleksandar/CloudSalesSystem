using System.ComponentModel.DataAnnotations;
using Application.Dto;
using MediatR;

namespace Application.Features.Licenses.ExtendLicense;

public record ExtendLicenseCommand : IRequest<License>
{
    [Required]
    public Guid LicenceId { get; set; }

    [Required]
    public DateOnly ValidTo { get; set; }
}