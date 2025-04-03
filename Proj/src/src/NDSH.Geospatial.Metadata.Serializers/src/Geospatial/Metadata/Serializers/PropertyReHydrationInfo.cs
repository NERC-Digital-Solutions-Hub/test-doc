
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
  internal class PropertyReHydrationInfo {

    /// <summary>
    /// 
    /// </summary>
    public readonly Type Type;

    /// <summary>
    /// 
    /// </summary>
    public readonly bool IsGenericType;

    /// <summary>
    /// 
    /// </summary>
    public readonly Type GenericType;

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
    public readonly string XmlArray;

    /// <summary>
    /// 
    /// </summary>
    public readonly string XmlArrayNamespace;

    /// <summary>
    /// 
    /// </summary>
    public readonly string XmlArrayItem;

    /// <summary>
    /// 
    /// </summary>
    public readonly string XmlArrayItemNamespace;

    /// <summary>
    /// 
    /// </summary>
    public readonly string XmlElement;

    /// <summary>
    /// 
    /// </summary>
    public readonly string XmlAttribute;

    /// <summary>
    /// 
    /// </summary>
    public readonly int Order;

  }

}
