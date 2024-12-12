using Microsoft.AspNetCore.Components;

namespace CarsBlazorHybrid.Application.Components;

public class CancellableComponent : ComponentBase, IDisposable
{
    internal CancellationTokenSource _cts = new();

    public virtual void Dispose()
    {
        _cts.Cancel();
        _cts.Dispose();
    }
}