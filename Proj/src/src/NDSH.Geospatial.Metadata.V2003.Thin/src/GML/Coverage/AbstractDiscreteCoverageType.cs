
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coverage {


  [XmlInclude(typeof(RectifiedGridCoverageType))]
  [XmlInclude(typeof(GridCoverageType))]
  [XmlInclude(typeof(MultiSolidCoverageType))]
  [XmlInclude(typeof(MultiSurfaceCoverageType))]
  [XmlInclude(typeof(MultiCurveCoverageType))]
  [XmlInclude(typeof(MultiPointCoverageType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractDiscreteCoverageType")]
  public abstract class AbstractDiscreteCoverageType : AbstractCoverageType {
    #region Private fields
    private CoverageFunctionType _coverageFunction;
    #endregion

    /// <summary>
    /// AbstractDiscreteCoverageType class constructor
    /// </summary>
    public AbstractDiscreteCoverageType() {
      _coverageFunction = new CoverageFunctionType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("coverageFunction", Order = 0)]
    public CoverageFunctionType coverageFunction {
      get {
        return _coverageFunction;
      }
      set {
        if (_coverageFunction == value) {
          return;
        }
        if (_coverageFunction == null || _coverageFunction.Equals(value) != true) {
          _coverageFunction = value;
          OnPropertyChanged("coverageFunction");
        }
      }
    }
  }
}