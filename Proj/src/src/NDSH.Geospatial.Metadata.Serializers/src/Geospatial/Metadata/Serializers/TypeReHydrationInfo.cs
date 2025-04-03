
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
  internal struct TypeReHydrationInfo {

    #region Constructors - Destructors

    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="xmlRoot"></param>
    /// <param name="xmlType"></param>
    /// <param name="xmlNamespace"></param>
    /// <param name="xmlNamespaces"></param>
    /// <param name="isNullable"></param>
    public TypeReHydrationInfo(
      Type type,
      string name,
      string @namespace,
      string xmlRoot,
      string xmlType,
      string xmlNamespace,
      List<string> xmlNamespaces,
      bool isNullable
    ) {

      Type = type;
      Name = name;
      Namespace = @namespace;
      XmlRoot = xmlRoot;
      XmlType = xmlType;
      XmlNamespace = xmlNamespace;
      XmlNamespaces = xmlNamespaces;
      IsNullable = isNullable;
      
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// 
    /// </summary>
    public readonly Type Type;

    /// <summary>
    /// 
    /// </summary>
    public readonly string Name;

    /// <summary>
    /// 
    /// </summary>
    public readonly string Namespace;

    /// <summary>
    /// 
    /// </summary>
    public readonly string XmlRoot;

    /// <summary>
    /// 
    /// </summary>
    public readonly string XmlType;

    /// <summary>
    /// 
    /// </summary>
    public readonly string XmlNamespace;

    /// <summary>
    /// 
    /// </summary>
    public readonly List<string> XmlNamespaces;

    /// <summary>
    /// 
    /// </summary>
    public readonly bool IsNullable;

    #endregion

  }

}
