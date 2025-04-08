
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums {

  [Serializable]
  [XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  public enum SecondDefiningParameterIsSphere {

    sphere,

  }

}
