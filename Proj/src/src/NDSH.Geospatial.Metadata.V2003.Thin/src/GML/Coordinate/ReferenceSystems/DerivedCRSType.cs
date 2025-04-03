
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.ReferenceSystems
{

  [XmlInclude(typeof(ML_DerivedCRS_Type))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DerivedCRSType")]
  public class DerivedCRSType : AbstractGeneralDerivedCRSType
  {
    #region Private fields
    private SingleCRSPropertyType _baseCRS;
    private CodeWithAuthorityType _derivedCRSType;
    private CoordinateSystemPropertyType _coordinateSystem;
    #endregion

    /// <summary>
    /// DerivedCRSType class constructor
    /// </summary>
    public DerivedCRSType()
    {
      _coordinateSystem = new CoordinateSystemPropertyType();
      _derivedCRSType = new CodeWithAuthorityType();
      _baseCRS = new SingleCRSPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("baseCRS", Order = 0)]
    public SingleCRSPropertyType baseCRS
    {
      get
      {
        return _baseCRS;
      }
      set
      {
        if (_baseCRS == value)
        {
          return;
        }
        if (_baseCRS == null || _baseCRS.Equals(value) != true)
        {
          _baseCRS = value;
          OnPropertyChanged("baseCRS");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("derivedCRSType", Order = 1)]
    public CodeWithAuthorityType derivedCRSType
    {
      get
      {
        return _derivedCRSType;
      }
      set
      {
        if (_derivedCRSType == value)
        {
          return;
        }
        if (_derivedCRSType == null || _derivedCRSType.Equals(value) != true)
        {
          _derivedCRSType = value;
          OnPropertyChanged("derivedCRSType");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("coordinateSystem", Order = 2)]
    public CoordinateSystemPropertyType coordinateSystem
    {
      get
      {
        return _coordinateSystem;
      }
      set
      {
        if (_coordinateSystem == value)
        {
          return;
        }
        if (_coordinateSystem == null || _coordinateSystem.Equals(value) != true)
        {
          _coordinateSystem = value;
          OnPropertyChanged("coordinateSystem");
        }
      }
    }
  }
}