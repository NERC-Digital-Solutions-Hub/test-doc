
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 03:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(AbstractTimeTopologyPrimitiveType))]
  [XmlInclude(typeof(TimeEdgeType))]
  [XmlInclude(typeof(TimeNodeType))]
  [XmlInclude(typeof(AbstractTimeGeometricPrimitiveType))]
  [XmlInclude(typeof(TimePeriodType))]
  [XmlInclude(typeof(TimeInstantType))]
  [XmlType("AbstractTimePrimitiveType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimePrimitiveType")]
  public abstract class AbstractTimePrimitiveType : AbstractTimeObjectType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractTimePrimitiveType"/>.
    /// </summary>
    public AbstractTimePrimitiveType() {
      _relatedTime = default; //  new List<RelatedTimeType>();
    }

    #endregion

    #region Public Properties

    private List<RelatedTimeType> _relatedTime;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("relatedTime", Order = 0)]
    [JsonProperty("relatedTime", Order = 0)]
    public List<RelatedTimeType> RelatedTime {
      get {
        return _relatedTime;
      }
      set {
        if (_relatedTime == value) {
          return;
        }
        if (_relatedTime == null || _relatedTime.Equals(value) != true) {
          _relatedTime = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
