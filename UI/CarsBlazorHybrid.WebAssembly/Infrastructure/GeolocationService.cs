using CarsBlazorHybrid.Application.Abstractions;
using Microsoft.JSInterop;
using IGeolocationService = CarsBlazorHybrid.Application.Abstractions.IGeolocationService;

namespace CarsBlazorHybrid.WebAssembly.Infrastructure;

public class GeolocationService(IJSRuntime jsRuntime) : IGeolocationService
{
    public async Task<GeolocationDto?> GetCurrentGeolocationAsync(CancellationToken cancellationToken)
    {
        return await jsRuntime.InvokeAsync<GeolocationDto>("getLocation", cancellationToken, null);
    }
}