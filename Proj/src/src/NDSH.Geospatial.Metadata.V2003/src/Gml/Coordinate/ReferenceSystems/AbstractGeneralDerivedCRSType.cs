
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
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

  [XmlInclude(typeof(DerivedCRSType))]
  [XmlInclude(typeof(ProjectedCRSType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralDerivedCRSType")]
  public abstract class AbstractGeneralDerivedCRSType : AbstractCRSType {

    #region Private fields
    private GeneralConversionPropertyType _conversion;
    #endregion

    /// <summary>
    /// AbstractGeneralDerivedCRSType class constructor
    /// </summary>
    public AbstractGeneralDerivedCRSType() {
      _conversion = new GeneralConversionPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("conversion", Order = 0)]
    public GeneralConversionPropertyType Conversion {
      get {
        return _conversion;
      }
      set {
        if (_conversion == value) {
          return;
        }
        if (_conversion == null || _conversion.Equals(value) != true) {
          _conversion = value;
          OnPropertyChanged("Conversion");
        }
      }
    }

  }

}
