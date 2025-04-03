//#define LOCAL_DB

using Microsoft.EntityFrameworkCore;
using NDSH.Geospatial.Metadata.Utilities.DatabaseContext;
using System.Diagnostics;
using Serilog;
using HotChocolate.Execution.Instrumentation;
using HotChocolate.Execution.Processing;
using HotChocolate.Execution;
using HotChocolate.Resolvers;

// following: https://chillicream.com/docs/hotchocolate/v13/integrations/entity-framework
// see also: https://www.youtube.com/watch?v=BcTPIGLYB0I
// see also: https://chillicream.com/docs/hotchocolate/v13/get-started-with-graphql-in-net-core


/// <summary>
/// 
/// </summary>
internal class Program {

  /// <summary>
  /// 
  /// </summary>
  /// <param name="args"></param>
  private static void Main(string[] args) {

    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog((ctx, lc) => lc
        .WriteTo.Console()
        .WriteTo.Seq("http://localhost:5341"));



#if LOCAL_DB

string? connString = builder.Configuration.GetConnectionString("SQLite-Local");
Debug.Assert(connString is not null);

builder.Services.AddPooledDbContextFactory<MetadataContextGraphApi>(
  options => options.UseSqlite(connString)
);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins"; // CORS for blazor, see Properties/launchSetting.json in NDSH.Geospatial.Demos.SearchAndMap.Blazor
string[] origins = { "http://localhost", "http://localhost:5022", "https://localhost", "https://localhost:7205", "http://localhost:44367", "https://localhost:44362" };

builder.Services.AddCors(options => {
  options.AddPolicy(name: MyAllowSpecificOrigins,
                    policy => {
                      policy.WithOrigins(origins)
                      .AllowAnyHeader()
                      .AllowAnyMethod();
                    });
});

#else

    string? connString = builder.Configuration.GetConnectionString("PostgreSQL-AWS");

    builder.Services.AddPooledDbContextFactory<MetadataContextGraphApi>(
      options => options.UseNpgsql(connString)
    );

    var MyAllowSpecificOrigins = "_myAllowSpecificOrigins"; // CORS for blazor, see Properties/launchSetting.json in NDSH.Geospatial.Demos.SearchAndMap.Blazor
    string[] origins = { "http://localhost", "http://localhost:5022", "https://localhost", "https://localhost:7205", "http://localhost:44367", "https://localhost:44362" };

    builder.Services.AddCors(options => {
      options.AddPolicy(name: MyAllowSpecificOrigins,
                        policy => {
                          policy.WithOrigins(origins)
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                        });
    });


#endif




    builder.Services.AddGraphQLServer()
      .AddFiltering()
      .RegisterDbContext<MetadataContextGraphApi>(DbContextKind.Pooled)
      .AddDiagnosticEventListener<ErrorLoggingDiagnosticsEventListener>()
      .AddQueryType<Query>();

      var app = builder.Build();

      app.UseStaticFiles();
      app.MapGraphQL();


      if (builder.Environment.IsDevelopment())
        app.UseDeveloperExceptionPage();

    app.UseCors(MyAllowSpecificOrigins);

    app.Run();

  }
}


/// <summary>
/// error log catcher for debugging purpose.
/// </summary>
public class ErrorLoggingDiagnosticsEventListener : ExecutionDiagnosticEventListener {
  private readonly ILogger<ErrorLoggingDiagnosticsEventListener> log;

  public ErrorLoggingDiagnosticsEventListener(
      ILogger<ErrorLoggingDiagnosticsEventListener> log) {
    this.log = log;
  }

  public override void ResolverError(
      IMiddlewareContext context,
      IError error) {
    log.LogError(error.Exception, error.Message);
  }

  public override void TaskError(
      IExecutionTask task,
      IError error) {
    log.LogError(error.Exception, error.Message);
  }

  public override void RequestError(
      IRequestContext context,
      Exception exception) {
    log.LogError(exception, "RequestError");
  }

  public override void SubscriptionEventError(
      SubscriptionEventContext context,
      Exception exception) {
    log.LogError(exception, "SubscriptionEventError");
  }

  public override void SubscriptionTransportError(
      ISubscription subscription,
      Exception exception) {
    log.LogError(exception, "SubscriptionTransportError");
  }
}




