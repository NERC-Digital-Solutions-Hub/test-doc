
#region Imported Namespaces

using Esri.ArcGISRuntime;
using Esri.ArcGISRuntime.Http;
using Esri.ArcGISRuntime.Security;
using NDSH.Database;
using NDSH.Geospatial.Demos.SearchAndMap.Binders;
using NDSH.Geospatial.Demos.SearchAndMap.Models;
using NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch;
using NDSH.Geospatial.Demos.SearchAndMap.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap {

  /// <summary>
  /// The Bootstrapper of the application.
  /// </summary>
  public partial class Bootstrapper : Application {

    /// <summary>
    /// Occurs on application startup.
    /// </summary>
    /// <param name="e">The <see cref="StartupEventArgs"/>.</param>
    protected override void OnStartup(StartupEventArgs e) {
      base.OnStartup(e);

      // TODO: IMPORTANT!!! - Make sure that a default configuration is extracted from the resources and added in the user's directory.

      string configFile = ConfigurationManager.AppSettings["appConfigFile"];
      if (configFile == null) {
        throw new NullReferenceException("Unable to retrieve the configuration file location."); // TODO: Add to Resources.
      }

      ReadConfiguration(configFile);
      
      //WriteConfiguration(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataSearchAndMap\application-configuration.json");

      /* Authentication for ArcGIS location services:
       * Use of ArcGIS location services, including basemaps and geocoding, requires either:
       * 1) ArcGIS identity (formerly "named user"): An account that is a member of an organization in ArcGIS Online or ArcGIS Enterprise
       *    giving your application permission to access the content and location services authorized to an existing ArcGIS user's account.
       *    You'll get an identity by signing into the ArcGIS Portal.
       * 2) API key: A permanent token that grants your application access to ArcGIS location services.
       *    Create a new API key or access existing API keys from your ArcGIS for Developers
       *    dashboard (https://links.esri.com/arcgis-api-keys) then call .UseApiKey("[Your ArcGIS location services API Key]")
       *    in the initialize call below. */

      /* Licensing:
       * Production deployment of applications built with the ArcGIS Maps SDK requires you to license ArcGIS functionality.
       * For more information see https://links.esri.com/arcgis-runtime-license-and-deploy.
       * You can set the license string by calling .UseLicense(licenseString) in the initialize call below 
       * or retrieve a license dynamically after signing into a portal:
       * ArcGISRuntimeEnvironment.SetLicense(await myArcGISPortal.GetLicenseInfoAsync()); */
      try {

        // Initialize the ArcGIS Maps SDK runtime before any components are created.
        ArcGISRuntimeEnvironment.Initialize(config => config
          // .UseLicense("[Your ArcGIS Maps SDK License key]")
          //.UseApiKey(Bootstrapper.ApiKey)
          .UseApiKey(AppEngine.Instance.ApplicationModel.ApiKey)
          .ConfigureAuthentication(auth => auth
             .UseDefaultChallengeHandler() // Use the default authentication dialog
                                           // .UseOAuthAuthorizeHandler(myOauthAuthorizationHandler) // Configure a custom OAuth dialog
           )
        );

        // Register all the binders of the application. This is a simple hardcoded solution.
        AppEngine.Instance.Catalogue.Register();

        // Get the ShellBinder and its associated ShellView and display the application's shell view on the screen.
        ShellBinder shellBinder = (ShellBinder)AppEngine.Instance.Catalogue.Binders[nameof(ShellBinder)];
        shellBinder.ShellView = new ShellView();
        shellBinder.ShellView.Show();

      }
      catch (Exception ex) {
        MessageBox.Show(ex.ToString(), "ArcGIS Maps SDK runtime initialization failed."); // TODO: Add to Resources

        // Exit application.
        this.Shutdown();
      }

    }

    #region Private Procedures

    /// <summary>
    /// Reads the application configuration from the config file.
    /// </summary>
    /// <param name="jsonConfigFile">
    /// The full path to the JSON configuration file.
    /// </param>
    private void ReadConfiguration(string jsonConfigFile) {

      if (jsonConfigFile == null) {
        throw new ArgumentNullException($"Argument {nameof(jsonConfigFile)} is null.");
      }

      Newtonsoft.Json.JsonSerializer serializer = new() {
        Formatting = Newtonsoft.Json.Formatting.Indented,
        TypeNameHandling = TypeNameHandling.Objects
      };
      serializer.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

      using (var sr = new StreamReader(jsonConfigFile))
      using (var reader = new JsonTextReader(sr)) {
        AppEngine.Instance.ApplicationModel = serializer.Deserialize<ApplicationModel>(reader);
      }

    }

    /// <summary>
    /// Writes the configuration to the config file.
    /// </summary>
    /// <param name="jsonConfigFile">
    /// The full path to the JSON configuration file.
    /// </param>
    private void WriteConfiguration(string jsonConfigFile) {

      // TODO: Comment out the applicationModel creation. It is used to generate a configuration file initially, when developing the application.

      ApplicationModel applicationModel = new ApplicationModel() {
        ApiKey = "your-api-key",
        DatabaseConnectionsInfo = new() {
          {
            new SqliteConnectionInfo() {
              FilePath = @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\2023-03-07-metadata.db",
              Name = "SQLite"
            }
          },
          {
            new PostgreSqlConnectionInfo() {
              Database = "database",
              Host = "host",
              Name = "PostgreSQL",
              Password = "password",
              Username = "username",
            }
          }
        },
        Service = new Service() {
          Url = "metadata-search-api-url",
          Content = new Content() {
            Encoding = Models.Services.MetadataSemanticSearch.Encoding.Utf8,
            MediaType = "application/json"
          },
          Requests = new List<Request>() {
            {
              new Request() {
                IsUsed = true,
                QueryField = "title",
                ReturnedFields = new List<string>() {
                  "identifier",
                  "recordId",
                  "title",
                  //"title_emb",
                  //"abstract",
                  //"abstract_emb",
                  "scores"
                },
                TopNumberOfRecords = 20
              }
            },
            {
              new Request() {
                IsUsed = true,
                QueryField = "abstract",
                ReturnedFields = new List<string>() {
                  "identifier",
                  "recordId",
                  "title",
                  //"title_emb",
                  //"abstract",
                  //"abstract_emb",
                  "scores"
                },
                TopNumberOfRecords = 20
              }
            }
          }
        }
      };

      AppEngine.Instance.ApplicationModel = applicationModel;

      Newtonsoft.Json.JsonSerializer serializer = new() {
        Formatting = Newtonsoft.Json.Formatting.Indented,
        TypeNameHandling = TypeNameHandling.Objects
      };
      serializer.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

      using (var sw = new StreamWriter(jsonConfigFile))
      using (JsonWriter writer = new JsonTextWriter(sw)) {
        serializer.Serialize(writer, AppEngine.Instance.ApplicationModel);
      }

    }

    #endregion

  }

}
