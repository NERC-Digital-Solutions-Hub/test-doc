using Serilog;
using Serilog.Core;

namespace NDSH.Geospatial.Metadata.Utilities {

  /// <summary>
  /// 
  /// </summary>
  public class MyLogger {

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fp"></param>
    /// <returns></returns>
    static public Logger InitLogger(string fp) {
      if (string.IsNullOrEmpty(fp)) {
        return new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();
      }
      else {
        string outputTemplate = "[{Level:u3}] {Message:lj}{NewLine}{Exception}";
        return new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(fp, outputTemplate: outputTemplate)
                .CreateLogger();
      }
    }

  }

}
