var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.dkc_messaging_portal_Server>("dkc-messaging-portal-server");

builder.Build().Run();
