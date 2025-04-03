
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


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractContinuousCoverageType")]
  public abstract class AbstractContinuousCoverageType : AbstractCoverageType {
    #region Private fields
    private CoverageFunctionType _coverageFunction;
    #endregion

    /// <summary>
    /// AbstractContinuousCoverageType class constructor
    /// </summary>
    public AbstractContinuousCoverageType() {
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