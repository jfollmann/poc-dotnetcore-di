using Microsoft.Extensions.DependencyInjection;

namespace POC.DI.Scoped
{
  public interface IExampleScopedService : IReportServiceLifetime
  {
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
  }
}