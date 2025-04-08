
#region Imported Namespaces

using NDSH.Geospatial.Demos.SearchAndMap.Blazor.Models;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Blazor {

  /// <summary>
  /// The singleton application engine.
  /// </summary>
  internal sealed class AppEngine {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AppEngine"/>.
    /// </summary>
    /// <remarks>
    /// This is a private constructor to ensure that no client can instantiate this class directly.
    /// </remarks>
    private AppEngine() {
      _catalogue = new AppCatalogue();
    }

    #endregion

    #region Public Properties

    private static readonly AppEngine _instance = new AppEngine();

    /// <summary>
    /// Gets the singleton instance of the <see cref="AppEngine"/>.
    /// </summary>
    public static AppEngine Instance {
      get {
        return _instance;
      }
    }

    private ApplicationModel _applicationModel;

    /// <summary>
    /// Gets/Sets the <see cref="ApplicationModel"/>.
    /// </summary>
    public ApplicationModel ApplicationModel {
      get {
        return _applicationModel;
      }
      internal set {
        if (value == null) {
          throw new NullReferenceException("The application's model can not be null.");
        }
        if (_applicationModel == value) {
          throw new Exception("The application's model can be set only once.");
        }
        _applicationModel = value;
      }
    }

    private readonly AppCatalogue _catalogue;

    /// <summary>
    /// Gets the <see cref="AppCatalogue"/> of the application.
    /// </summary>
    public AppCatalogue Catalogue {
      get {
        return _catalogue;
      }
    }

    #endregion

  }

}
