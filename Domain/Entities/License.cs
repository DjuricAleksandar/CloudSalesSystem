using Domain.Enums;

namespace Domain.Entities;

public record License : BaseRecord
{
    public Guid Id { get; set; }
    public Guid ServiceId { get; set; }
    public Guid AccountId { get; set; }
    public States State { get; set; }
    public DateOnly ValidTo { get; set; }

    public Service? Service { get; set; }
    public Account? Account { get; set; }
}