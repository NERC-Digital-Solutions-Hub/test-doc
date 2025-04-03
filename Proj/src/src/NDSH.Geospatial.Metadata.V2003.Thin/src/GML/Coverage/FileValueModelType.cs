
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
  public enum FileValueModelType {
    [XmlEnumAttribute("Record Interleaved")]
    [EnumMember(Value = "Record Interleaved")]
    RecordInterleaved,
  }
}