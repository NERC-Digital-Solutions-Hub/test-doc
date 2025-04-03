
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ML_OperationParameter_Type))] // GMX
  [XmlInclude(typeof(OperationParameterAlt_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationParameterType")]
  public class OperationParameterType : AbstractGeneralOperationParameterType {

  }

}
