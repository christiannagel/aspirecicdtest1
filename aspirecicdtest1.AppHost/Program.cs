var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.aspirecicdtest1_ApiService>("apiservice");

builder.AddProject<Projects.aspirecicdtest1_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
