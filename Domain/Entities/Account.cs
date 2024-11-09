namespace Domain.Entities;

public record Account
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}