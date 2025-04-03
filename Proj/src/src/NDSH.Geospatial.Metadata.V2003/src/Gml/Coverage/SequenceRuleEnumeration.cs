
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coverage {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum SequenceRuleEnumeration {

    Linear,
    Boustrophedonic,
    [XmlEnumAttribute("Cantor-diagonal")]
    [EnumMember(Value = "Cantor-diagonal")]
    Cantordiagonal,
    Spiral,
    Morton,
    Hilbert,

  }

}
