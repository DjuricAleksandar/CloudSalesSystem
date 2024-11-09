using System.ComponentModel.DataAnnotations;
using Application.Dto;
using MediatR;

namespace Application.Features.Licences.AcquireLicence;

public record AcquireLicenceCommand : IRequest<Licence>
{
    [Required]
    public Guid AccountId { get; set; }

    [Required]
    public Guid ServiceId { get; set; }
}