
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
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.ReferenceSystems
{


  [XmlInclude(typeof(DerivedCRSType))]
  [XmlInclude(typeof(ProjectedCRSType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralDerivedCRSType")]
  public abstract class AbstractGeneralDerivedCRSType : AbstractCRSType
  {
    #region Private fields
    private GeneralConversionPropertyType _conversion;
    #endregion

    /// <summary>
    /// AbstractGeneralDerivedCRSType class constructor
    /// </summary>
    public AbstractGeneralDerivedCRSType()
    {
      _conversion = new GeneralConversionPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("conversion", Order = 0)]
    public GeneralConversionPropertyType conversion
    {
      get
      {
        return _conversion;
      }
      set
      {
        if (_conversion == value)
        {
          return;
        }
        if (_conversion == null || _conversion.Equals(value) != true)
        {
          _conversion = value;
          OnPropertyChanged("conversion");
        }
      }
    }
  }
}