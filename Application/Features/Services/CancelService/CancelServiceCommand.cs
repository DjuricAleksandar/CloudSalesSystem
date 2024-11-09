using System.ComponentModel.DataAnnotations;
using Application.Dto;
using MediatR;

namespace Application.Features.Services.CancelService;

public record CancelServiceCommand : IRequest<IEnumerable<License>>
{
    [Required]
    public Guid ServiceId { get; set; }
}