
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.ReferenceSystems
{

  [XmlInclude(typeof(ML_ProjectedCRS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ProjectedCRSType")]
  public class ProjectedCRSType : AbstractGeneralDerivedCRSType
  {
    #region Private fields
    private object _item;
    private CartesianCSPropertyType _cartesianCS;
    #endregion

    /// <summary>
    /// ProjectedCRSType class constructor
    /// </summary>
    public ProjectedCRSType()
    {
      _cartesianCS = new CartesianCSPropertyType();
    }

    [XmlElement("baseGeodeticCRS", typeof(GeodeticCRSPropertyType), Order = 0)]
    [XmlElement("baseGeographicCRS", typeof(GeographicCRSPropertyType), Order = 0)]
    public object Item
    {
      get
      {
        return _item;
      }
      set
      {
        if (_item == value)
        {
          return;
        }
        if (_item == null || _item.Equals(value) != true)
        {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("cartesianCS", Order = 1)]
    public CartesianCSPropertyType cartesianCS
    {
      get
      {
        return _cartesianCS;
      }
      set
      {
        if (_cartesianCS == value)
        {
          return;
        }
        if (_cartesianCS == null || _cartesianCS.Equals(value) != true)
        {
          _cartesianCS = value;
          OnPropertyChanged("cartesianCS");
        }
      }
    }
  }
}