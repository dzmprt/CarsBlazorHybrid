using CarsBlazorHybrid.Application.Abstractions;

namespace CarsBlazorHybrid.MAUI.Infrastructure;

public class GeolocationService : IGeolocationService
{
    public async Task<GeolocationDto?> GetCurrentGeolocationAsync(CancellationToken cancellationToken)
    {
        
        try
        {
            var location = await Geolocation.Default.GetLastKnownLocationAsync();
            if (location == null)
            {
                return null;
            }
            return new GeolocationDto()
            {
                Latitude = (decimal)location.Latitude,
                Longitude = (decimal)location.Longitude
            };
        }
        catch (Exception ex)
        {
            //TODO: log
            return null;
        }
    }
}