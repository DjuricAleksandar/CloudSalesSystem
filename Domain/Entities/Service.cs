namespace Domain.Entities;

public record Service : BaseRecord
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}