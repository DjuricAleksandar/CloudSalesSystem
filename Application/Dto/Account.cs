namespace Application.Dto;

public record Account
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}