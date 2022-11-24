1. Create Empty Asp .Net Core Project - "ApiGateway"
2. Add the nuget package "Ocelot" to the project
3. Create a ocelot.json file in the project and set it to copy if newer on build
4. In Program.cs we need to add the ocelot.json file to the configuration
```csharp 
builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();
```

We also include EnvironmentVariables for later on 

5. After the builder has been built, the middleware for ocelot must be added
```csharp
await app.UseOcelot()
```

The final Program.cs should look like this
```csharp
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

await app.UseOcelot();

app.Run();
``` 

