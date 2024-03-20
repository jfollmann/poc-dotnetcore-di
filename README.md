# .netCore - Dependency Injection

## Restore packages
```sh
dotnet restore
```

## Run project
```sh
dotnet run
```

## Types of Lifetime
| Type      | Same Request     | Other Request        |
|-----------|------------------|----------------------|
| Singleton | Same instance    | Same instance        |
| Scoped    | Same instance    | New instance         |
| Transient | New instance     | New instance         |

## Expected output project
```sh
Lifetime 1: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()
   IExampleTransientService: 4f062ec9-4929-4b2d-89ab-dcd190845fef (Always different)
   IExampleScopedService: b59c0445-ffe8-435c-9af0-ee028e79ecb4 (Chages only with lifetime)
   IExampleSingletonService: b1ad5368-d305-4f9d-9586-56eafd5f1cba (Always the same)
...
Lifetime 1: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()
   IExampleTransientService: 2185c694-5674-42d2-b8ff-ee2b8f35837b (Always different)
   IExampleScopedService: b59c0445-ffe8-435c-9af0-ee028e79ecb4 (Chages only with lifetime)
   IExampleSingletonService: b1ad5368-d305-4f9d-9586-56eafd5f1cba (Always the same)

Lifetime 2: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()
   IExampleTransientService: b77b61f3-f73d-4a95-8073-c1afe67dc5fd (Always different)
   IExampleScopedService: 39276cc2-127a-45f9-8dce-6c10a13601c4 (Chages only with lifetime)
   IExampleSingletonService: b1ad5368-d305-4f9d-9586-56eafd5f1cba (Always the same)
...
Lifetime 2: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()
   IExampleTransientService: 9c841c9f-f237-4843-a730-6cec289f7830 (Always different)
   IExampleScopedService: 39276cc2-127a-45f9-8dce-6c10a13601c4 (Chages only with lifetime)
   IExampleSingletonService: b1ad5368-d305-4f9d-9586-56eafd5f1cba (Always the same)
```

Reference: 
- https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage
- https://pt.stackoverflow.com/a/528207