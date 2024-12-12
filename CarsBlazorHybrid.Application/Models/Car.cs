namespace CarsBlazorHybrid.Application.Models;

public record struct Car
{
    public int CarId { get; init; }
    
    public CarModel Model { get; init; }
    
    public CarColor Color { get; init; }
    
    public string Vin { get; init; }
    
    public Decimal Price { get; init; }
}