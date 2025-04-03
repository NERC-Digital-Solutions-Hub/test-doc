
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
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums
{


  /// <summary>
  /// The TemporalDatumBaseType partially defines the origin of a temporal coordinate reference system. This type restricts the AbstractDatumType to remove the "anchorDefinition" and "realizationEpoch" elements.
  /// </summary>
  [XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  [XmlInclude(typeof(TemporalDatumType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalDatumBaseType")]
  public abstract class TemporalDatumBaseType : AbstractDatumType
  {
  }
}