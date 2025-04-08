
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coverage {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum IncrementOrder {
    [XmlEnumAttribute("+x+y")]
    [EnumMember(Value = "+x+y")]
    xy,
    [XmlEnumAttribute("+y+x")]
    [EnumMember(Value = "+y+x")]
    yx,
    [XmlEnumAttribute("+x-y")]
    [EnumMember(Value = "+x-y")]
    xy1,
    [XmlEnumAttribute("-x-y")]
    [EnumMember(Value = "-x-y")]
    xy2,
  }
}