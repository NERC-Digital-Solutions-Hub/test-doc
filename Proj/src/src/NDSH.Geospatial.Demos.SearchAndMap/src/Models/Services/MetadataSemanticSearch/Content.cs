
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch {

  /// <summary>
  /// The content of the metadata semantic search service.
  /// </summary>
  public class Content : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Content"/>.
    /// </summary>
    /// <remarks>
    /// By default the <see cref="Encoding"/> is set to <see cref="Encoding.Utf8"/>
    /// and the <see cref="MediaType"/> is set to "application/json".
    /// </remarks>
    public Content() {
      Encoding = Encoding.Utf8;
      MediaType = "application/json";
    }

    /// <summary>
    /// Initializes the <see cref="Content"/>.
    /// </summary>
    /// <param name="encoding">The <see cref="Encoding"/> of the content.</param>
    /// <param name="mediaType">The media type of the content.</param>
    public Content(Encoding encoding, string mediaType) {
      Encoding = encoding;
      MediaType = mediaType;
    }

    #endregion

    #region Public Properties

    private Encoding _encoding;

    /// <summary>
    /// Gets/Sets the encoding of the content.
    /// </summary>
    public Encoding Encoding {
      get {
        return _encoding;
      }
      set {
        if (_encoding != value) {
          _encoding = value;
          OnPropertyChanged();
        }
      }
    }

    private string _mediaType;

    /// <summary>
    /// Gets/Sets the media type of the content.
    /// </summary>
    public string MediaType {
      get {
        return _mediaType;
      }
      set {
        if (_mediaType != value) {
          _mediaType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
