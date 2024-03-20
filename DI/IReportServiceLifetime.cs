using Microsoft.Extensions.DependencyInjection;

namespace POC.DI
{
  public interface IReportServiceLifetime
  {
    Guid Id { get; }
    ServiceLifetime Lifetime { get; }
  }
}