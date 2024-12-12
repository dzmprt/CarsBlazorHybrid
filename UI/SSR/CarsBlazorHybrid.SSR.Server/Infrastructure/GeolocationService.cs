using CarsBlazorHybrid.Application.Abstractions;
using Microsoft.JSInterop;
using IGeolocationService = CarsBlazorHybrid.Application.Abstractions.IGeolocationService;

namespace CarsBlazorHybrid.SSR.Server.Infrastructure;

public class GeolocationService(IJSRuntime jsRuntime) : IGeolocationService
{
    public async Task<GeolocationDto?> GetCurrentGeolocationAsync(CancellationToken cancellationToken)
    {
        try
        {
            return await jsRuntime.InvokeAsync<GeolocationDto>("getLocation", cancellationToken, null);
        }
        catch (InvalidOperationException exception)
        {
            return null;
        }
    }
}