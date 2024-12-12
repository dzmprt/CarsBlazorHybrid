namespace CarsBlazorHybrid.Application.Abstractions;

public interface IGeolocationService
{
    Task<GeolocationDto?> GetCurrentGeolocationAsync(CancellationToken cancellationToken);
}