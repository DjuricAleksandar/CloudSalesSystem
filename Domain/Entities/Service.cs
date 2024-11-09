namespace Domain.Entities;

public record Service
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}