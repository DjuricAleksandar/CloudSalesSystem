using System.ComponentModel.DataAnnotations;
using Application.Dto;
using MediatR;

namespace Application.Features.Licenses.CancelLicense;

public record CancelLicenseCommand : IRequest<License>
{
    [Required]
    public Guid LicenceId { get; set; }
}