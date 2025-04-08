
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes {

  /// <summary>
  /// gml:SignType is a convenience type with values �+� (plus) and �-� (minus).
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum SignType {
    [XmlEnumAttribute("-")]
    [EnumMember(Value = "-")]
    Item,
    [XmlEnumAttribute("+")]
    [EnumMember(Value = "+")]
    Item1,
  }

}
