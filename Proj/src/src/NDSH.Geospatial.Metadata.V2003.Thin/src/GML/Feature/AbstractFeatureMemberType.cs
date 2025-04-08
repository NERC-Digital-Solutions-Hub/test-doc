
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature.Dynamic;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature
{



  /// <summary>
  /// To create a collection of GML features, a property type shall be derived by extension from gml:AbstractFeatureMemberType.
  /// By default, this abstract property type does not imply any ownership of the features in the collection. The owns attribute of gml:OwnershipAttributeGroup may be used on a property element instance to assert ownership of a feature in the collection. A collection shall not own a feature already owned by another object.
  /// </summary>
  [XmlInclude(typeof(DynamicFeatureMemberType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractFeatureMemberType")]
  public abstract class AbstractFeatureMemberType : Model {
    #region Private fields
    private bool _owns;
    #endregion

    /// <summary>
    /// AbstractFeatureMemberType class constructor
    /// </summary>
    public AbstractFeatureMemberType() {
      _owns = false;
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }
  }
}