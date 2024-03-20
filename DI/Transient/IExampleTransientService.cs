using Microsoft.Extensions.DependencyInjection;

namespace POC.DI.Transient
{
  public interface IExampleTransientService : IReportServiceLifetime
  {
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
  }
}