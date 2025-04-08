
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
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems
{

  [XmlInclude(typeof(ML_CartesianCS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CartesianCSType")]
  public class CartesianCSType : AbstractCoordinateSystemType
  {
  }
}