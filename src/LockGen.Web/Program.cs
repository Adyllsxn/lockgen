var builder = WebAssemblyHostBuilder.CreateDefault(args);
    builder.AddArchitecture();
    await builder.Build().RunAsync();
