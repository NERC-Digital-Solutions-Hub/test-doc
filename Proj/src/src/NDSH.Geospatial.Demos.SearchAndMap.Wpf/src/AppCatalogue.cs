
#region Imported Namespaces

using NDSH.Geospatial.Demos.SearchAndMap.Binders;
using NDSH.Geospatial.Demos.SearchAndMap.Models.Presentation;
using NDSH.Geospatial.Demos.SearchAndMap.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap {

  /// <summary>
  /// 
  /// </summary>
  internal sealed class AppCatalogue {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AppCatalogue"/>.
    /// </summary>
    public AppCatalogue() {
      
    }

    #endregion

    #region Public Properties

    private Dictionary<string, IBinder> _binders;

    /// <summary>
    /// Gets the <see cref="Dictionary{TKey, TValue}"/> of
    /// <see cref="string"/> keys and <see cref="IBinder"/> values.
    /// </summary>
    public Dictionary<string, IBinder> Binders {
      get {
        return _binders;
      }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// 
    /// </summary>
    public void Register() {

      if (_binders == null) {
        _binders= new Dictionary<string, IBinder>();
      }
      
      MetadataSearchBinder metadataSearchBinder = new MetadataSearchBinder(new MetadataSearchModel());
      _binders.Add(metadataSearchBinder.BinderName, metadataSearchBinder);
      
      ShellBinder shellBinder = new ShellBinder(new ShellModel());
      _binders.Add(shellBinder.BinderName, shellBinder);

    }

    #endregion

  }

}
