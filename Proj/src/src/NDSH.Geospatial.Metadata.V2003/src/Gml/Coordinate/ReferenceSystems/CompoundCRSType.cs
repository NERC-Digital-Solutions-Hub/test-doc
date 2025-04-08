
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
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

  [XmlInclude(typeof(ML_CompoundCRS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompoundCRSType")]
  public class CompoundCRSType : AbstractCRSType {

    #region Private fields
    private List<SingleCRSPropertyType> _componentReferenceSystem;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompoundCRSType class constructor
    /// </summary>
    public CompoundCRSType() {
      _componentReferenceSystem = new List<SingleCRSPropertyType>();
    }

    [XmlElement("componentReferenceSystem", Order = 0)]
    [Required()]
    [JsonProperty("componentReferenceSystem", Order = 0)]
    public List<SingleCRSPropertyType> ComponentReferenceSystem {
      get {
        return _componentReferenceSystem;
      }
      set {
        if (_componentReferenceSystem == value) {
          return;
        }
        if (_componentReferenceSystem == null || _componentReferenceSystem.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ComponentReferenceSystem";
          Validator.ValidateProperty(value, validatorPropContext);
          _componentReferenceSystem = value;
          OnPropertyChanged("ComponentReferenceSystem");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }

  }

}
