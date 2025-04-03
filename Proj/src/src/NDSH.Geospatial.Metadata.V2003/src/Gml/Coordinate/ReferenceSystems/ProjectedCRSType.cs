
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems;
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

  [XmlInclude(typeof(ML_ProjectedCRS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ProjectedCRSType")]
  public class ProjectedCRSType : AbstractGeneralDerivedCRSType {

    #region Private fields
    private object _item;
    private CartesianCSPropertyType _cartesianCS;
    #endregion

    /// <summary>
    /// ProjectedCRSType class constructor
    /// </summary>
    public ProjectedCRSType() {
      _cartesianCS = new CartesianCSPropertyType();
    }

    [XmlElement("baseGeodeticCRS", typeof(GeodeticCRSPropertyType), Order = 0)]
    [XmlElement("baseGeographicCRS", typeof(GeographicCRSPropertyType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("cartesianCS", Order = 1)]
    public CartesianCSPropertyType CartesianCS {
      get {
        return _cartesianCS;
      }
      set {
        if (_cartesianCS == value) {
          return;
        }
        if (_cartesianCS == null || _cartesianCS.Equals(value) != true) {
          _cartesianCS = value;
          OnPropertyChanged("CartesianCS");
        }
      }
    }

  }

}
