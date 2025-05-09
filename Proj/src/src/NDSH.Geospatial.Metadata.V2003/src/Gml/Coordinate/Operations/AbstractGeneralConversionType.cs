﻿
#region Imported Namespaces

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

  [XmlInclude(typeof(ML_Conversion_Type))] // GMX
  [XmlInclude(typeof(ConversionType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralConversionType")]
  public abstract class AbstractGeneralConversionType : AbstractCoordinateOperationType {

  }

}
