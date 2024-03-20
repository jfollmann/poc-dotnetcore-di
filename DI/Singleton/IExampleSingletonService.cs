using Microsoft.Extensions.DependencyInjection;

namespace POC.DI.Singleton
{
  public interface IExampleSingletonService : IReportServiceLifetime
  {
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
  }
}