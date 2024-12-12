namespace CarsBlazorHybrid.Application.Models;

public record struct CarColor
{
    public int CarColorId { get; init; }
    
    public string Name { get; init; }
}