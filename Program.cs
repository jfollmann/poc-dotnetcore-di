using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POC.DI;
using POC.DI.Scoped;
using POC.DI.Singleton;
using POC.DI.Transient;

namespace poc_dotnet_di;

class Program
{
  static async Task Main(string[] args)
  {
    HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
    builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();
    builder.Services.AddScoped<IExampleScopedService, ExampleScopedService>();
    builder.Services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
    builder.Services.AddTransient<ServiceLifetimeReporter>();
    using IHost host = builder.Build();

    ExemplifyServiceLifeTime(host.Services, "Lifetime 1");
    ExemplifyServiceLifeTime(host.Services, "Lifetime 2");

    await host.RunAsync();
  }

  static void ExemplifyServiceLifeTime(IServiceProvider hostProvider, string lifetime)
  {
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifeTimeDetails($"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");

    Console.WriteLine("...");

    logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifeTimeDetails($"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()");

    Console.WriteLine();
  }
}
