using BlazorExample.Services;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                configure.Add(ServiceDescriptor.Singleton(new GeradorDeNumeros()));
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
