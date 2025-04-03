
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.ReferenceSystems {

  [XmlInclude(typeof(ML_EngineeringCRS_Type))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EngineeringCRSType")]
  public class EngineeringCRSType : AbstractCRSType {

    #region Private fields
    private CoordinateSystemPropertyType _coordinateSystem;
    private EngineeringDatumPropertyType _engineeringDatum;
    #endregion

    /// <summary>
    /// EngineeringCRSType class constructor
    /// </summary>
    public EngineeringCRSType() {
      _engineeringDatum = new EngineeringDatumPropertyType();
      _coordinateSystem = new CoordinateSystemPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("coordinateSystem", Order = 0)]
    public CoordinateSystemPropertyType CoordinateSystem {
      get {
        return _coordinateSystem;
      }
      set {
        if (_coordinateSystem == value) {
          return;
        }
        if (_coordinateSystem == null || _coordinateSystem.Equals(value) != true) {
          _coordinateSystem = value;
          OnPropertyChanged("CoordinateSystem");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("engineeringDatum", Order = 1)]
    public EngineeringDatumPropertyType EngineeringDatum {
      get {
        return _engineeringDatum;
      }
      set {
        if (_engineeringDatum == value) {
          return;
        }
        if (_engineeringDatum == null || _engineeringDatum.Equals(value) != true) {
          _engineeringDatum = value;
          OnPropertyChanged("EngineeringDatum");
        }
      }
    }

  }

}
