using NDSH.Utilities.App.Models;
using Newtonsoft.Json;
using System.Configuration;

namespace NDSH.Utilities.App {

  /// <summary>
  /// The application (program) object.
  /// </summary>
  internal static class Program {

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      Application.Run(new MainForm());
    }

  }

}
