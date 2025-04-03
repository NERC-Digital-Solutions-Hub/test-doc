
#region Imported Namespaces

using NDSH.Utilities.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Utilities.App {

  /// <summary>
  /// The singleton application engine.
  /// </summary>
  internal class AppEngine {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AppEngine"/>.
    /// </summary>
    /// <remarks>
    /// This is a private constructor to ensure that no client can instantiate this class directly.
    /// </remarks>
    private AppEngine() {

    }

    #endregion

    #region Public Properties

    private static AppEngine _instance;

    /// <summary>
    /// Gets the singleton instance of the <see cref="AppEngine"/>.
    /// </summary>
    public static AppEngine Instance {
      get {
        if (_instance == null) {
          _instance = new AppEngine();
        }
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
      set {
        if (_applicationModel != value) {
          _applicationModel = value;
        }
      }
    }

    #endregion

  }

}
