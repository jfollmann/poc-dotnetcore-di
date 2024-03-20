namespace POC.DI.Transient
{
  internal sealed class ExampleTransientService : IExampleTransientService
  {
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
  }
}