
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch {

  /// <summary>
  /// The metadata semantic search service.
  /// </summary>
  public sealed class Service : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Service"/>.
    /// </summary>
    public Service() {

    }

    /// <summary>
    /// Initializes the <see cref="Service"/>.
    /// </summary>
    /// <param name="url">The URL of the service.</param>
    public Service(string url) {
      Url = url;
    }

    /// <summary>
    /// Initializes the <see cref="Service"/>.
    /// </summary>
    /// <param name="url">The URL of the service.</param>
    /// <param name="content">The <see cref="Content"/> of the services.</param>
    public Service(string url, Content content) {
      Url = url;
      Content = content;
    }

    #endregion

    #region Public Properties

    private string _url;

    /// <summary>
    /// Gets/Sets the URL of the service.
    /// </summary>
    public string Url {
      get {
        return _url;
      }
      set {
        if (_url != value) {
          _url = value;
          OnPropertyChanged();
        }
      }
    }

    private Content _content;

    /// <summary>
    /// Gets/Sets the <see cref="Content"/> of the service.
    /// </summary>
    public Content Content {
      get {
        return _content;
      }
      set {
        if (_content != value) {
          _content = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Request> _requests;

    // TODO: Check to see if this produces correct XML documentation.

    /// <summary>
    /// Gets/Sets the <see cref="List{T}">List of <see cref="Request"/></see>
    /// </summary>
    public List<Request> Requests {
      get {
        return _requests;
      }
      set {
        if (_requests != value) {
          _requests = value;
          OnPropertyChanged();
        }
      }
    }

    private Result _result;

    /// <summary>
    /// Gets/Sets the <see cref="MetadataSemanticSearch.Result"/>.
    /// </summary>
    public Result Result {
      get {
        return _result;
      }
      set {
        if (_result != value) {
          _result = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
