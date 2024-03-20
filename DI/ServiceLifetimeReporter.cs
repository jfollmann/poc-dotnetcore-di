using POC.DI.Scoped;
using POC.DI.Singleton;
using POC.DI.Transient;

namespace POC.DI
{
  internal sealed class ServiceLifetimeReporter(
    IExampleTransientService transientService,
    IExampleScopedService scopedService,
    IExampleSingletonService singletonService)
  {
    public void ReportServiceLifeTimeDetails(string lifeTimeDetails)
    {
      Console.WriteLine(lifeTimeDetails);

      LogService(transientService, "Always different");
      LogService(scopedService, "Chages only with lifetime");
      LogService(singletonService, "Always the same");
    }

    private static void LogService<T>(T service, string message)
      where T : IReportServiceLifetime =>
        Console.WriteLine($"   {typeof(T).Name}: {service.Id} ({message})");
  }
}