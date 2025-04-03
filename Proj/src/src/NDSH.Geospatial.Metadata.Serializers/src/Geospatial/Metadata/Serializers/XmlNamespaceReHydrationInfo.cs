
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Serializers {

  /// <summary>
  /// 
  /// </summary>
  internal struct XmlNamespaceReHydrationInfo {

    #region Constructors - Destructors

    /// <summary>
    /// 
    /// </summary>
    /// <param name="prefix"></param>
    /// <param name="uri"></param>
    public XmlNamespaceReHydrationInfo(string prefix, string uri) {
      Prefix = prefix;
      Uri = uri;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// 
    /// </summary>
    public readonly string Prefix;

    /// <summary>
    /// 
    /// </summary>
    public readonly string Uri;

    #endregion

  }

}
