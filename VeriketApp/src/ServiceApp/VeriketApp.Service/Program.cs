using VeriketApp.Service.Utilities.Logging;
using VeriketApp.Service.Utilities.Logging.Concrete;
using VeriketApp.Service.Workers;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton(_ => new LogUtility(new FileLogger()));

builder.Services.AddHostedService<LoggingWorker>();

builder.Services.AddWindowsService();

IHost host = builder.Build();
host.Run();
