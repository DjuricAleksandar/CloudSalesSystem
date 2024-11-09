namespace Domain.Entities;

public record Account : BaseRecord
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}