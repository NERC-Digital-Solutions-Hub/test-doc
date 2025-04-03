
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
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

  [XmlInclude(typeof(ML_DerivedCRS_Type))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DerivedCRSType")]
  public class DerivedCRSType : AbstractGeneralDerivedCRSType {

    #region Private fields
    private SingleCRSPropertyType _baseCRS;
    private CodeWithAuthorityType _derivedCRSType;
    private CoordinateSystemPropertyType _coordinateSystem;
    #endregion

    /// <summary>
    /// DerivedCRSType class constructor
    /// </summary>
    public DerivedCRSType() {
      _coordinateSystem = new CoordinateSystemPropertyType();
      _derivedCRSType = new CodeWithAuthorityType();
      _baseCRS = new SingleCRSPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("baseCRS", Order = 0)]
    public SingleCRSPropertyType BaseCRS {
      get {
        return _baseCRS;
      }
      set {
        if (_baseCRS == value) {
          return;
        }
        if (_baseCRS == null || _baseCRS.Equals(value) != true) {
          _baseCRS = value;
          OnPropertyChanged("BaseCRS");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    [JsonProperty("derivedCRSType", Order = 1)]
    // HACK: Renamed the property to DerivedCrsType (instead of DerivedCRSType) to avoid Compiler Error CS0542
    // 'user-defined type' : member names cannot be the same as their enclosing type
    // https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0542?f1url=%3FappId%3Droslyn%26k%3Dk(CS0542)
    public CodeWithAuthorityType DerivedCrsType {
      get {
        return _derivedCRSType;
      }
      set {
        if (_derivedCRSType == value) {
          return;
        }
        if (_derivedCRSType == null || _derivedCRSType.Equals(value) != true) {
          _derivedCRSType = value;
          OnPropertyChanged("DerivedCrsType");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("coordinateSystem", Order = 2)]
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

  }

}
