using Blazorise;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using dymaptic.GeoBlazor.Core;
using Newtonsoft.Json;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models;
using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Binders;
using System.Diagnostics;

/// <summary>
/// Reads the application configuration from the config file.
/// </summary>
/// <param name="jsonConfigFile">
/// The full path to the JSON configuration file.
/// </param>
void ReadConfiguration(System.IO.Stream jsonConfigStream) {
  if (jsonConfigStream == null) {
    throw new Exception("jsonConfigStream is null.");
  }
  Newtonsoft.Json.JsonSerializer serializer = new() {
    Formatting = Newtonsoft.Json.Formatting.Indented,
    TypeNameHandling = TypeNameHandling.Objects
  };
  
  serializer.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

  using (var sr = new StreamReader(jsonConfigStream))
  using (var reader = new JsonTextReader(sr)) {
    AppEngine.Instance.ApplicationModel = serializer.Deserialize<ApplicationModel>(reader);
  }
}

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddGeoBlazor();
builder.Services
.AddBlazorise(options => {
  options.Immediate = true;
}).AddBootstrapProviders().AddFontAwesomeIcons();

// blazor way to get appsettings.json as fileStream
var client = new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
using var response = await client.GetAsync("appsettings.json");
using var stream = await response.Content.ReadAsStreamAsync();

ReadConfiguration(stream);

AppEngine.Instance.Catalogue.Register();


var metadataSearchBinder = AppEngine.Instance.Catalogue.Binders[nameof(MetadataSearchBinder)] as MetadataSearchBinder;
var shellBinder = AppEngine.Instance.Catalogue.Binders[nameof(ShellBinder)] as ShellBinder;

Debug.Assert(metadataSearchBinder != null);
Debug.Assert(shellBinder != null);

builder.Services.AddSingleton<MetadataSearchBinder>(metadataSearchBinder);
builder.Services.AddSingleton<ShellBinder>(shellBinder);



await builder.Build().RunAsync();

