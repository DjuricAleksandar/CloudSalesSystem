using Application.Enums;

namespace Application.Dto;

public record Licence
{
    public Guid Id { get; set; }
    public Guid ServiceId { get; set; }
    public Guid AccountId { get; set; }
    public States State { get; set; }
    public DateOnly ValidTo { get; set; }
}