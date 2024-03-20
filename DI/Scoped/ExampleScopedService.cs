namespace POC.DI.Scoped
{
  internal sealed class ExampleScopedService: IExampleScopedService
  {
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
  }
}