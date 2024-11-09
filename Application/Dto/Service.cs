namespace Application.Dto;

public record Service
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}