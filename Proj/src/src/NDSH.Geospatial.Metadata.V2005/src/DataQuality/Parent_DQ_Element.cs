
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot("Parent_DQ_Element")]
  [JsonObject("Parent_DQ_Element")]
  public class Parent_DQ_Element : EntityBase<Parent_DQ_Element> {

    #region Public Fields
    
    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private object _item;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_AbsoluteExternalPositionalAccuracy", typeof(DQ_AbsoluteExternalPositionalAccuracy), Order = 0)]
    [XmlElement("DQ_AccuracyOfATimeMeasurement", typeof(DQ_AccuracyOfATimeMeasurement), Order = 0)]
    [XmlElement("DQ_Completeness", typeof(DQ_Completeness), Order = 0)]
    [XmlElement("DQ_CompletenessCommission", typeof(DQ_CompletenessCommission), Order = 0)]
    [XmlElement("DQ_CompletenessOmission", typeof(DQ_CompletenessOmission), Order = 0)]
    [XmlElement("DQ_ConceptualConsistency", typeof(DQ_ConceptualConsistency), Order = 0)]
    [XmlElement("DQ_DomainConsistency", typeof(DQ_DomainConsistency), Order = 0)]
    [XmlElement("DQ_Element", typeof(DQ_Element), Order = 0)]
    [XmlElement("DQ_FormatConsistency", typeof(DQ_FormatConsistency), Order = 0)]
    [XmlElement("DQ_GriddedDataPositionalAccuracy", typeof(DQ_GriddedDataPositionalAccuracy), Order = 0)]
    [XmlElement("DQ_LogicalConsistency", typeof(DQ_LogicalConsistency), Order = 0)]
    [XmlElement("DQ_NonQuantitativeAttributeAccuracy", typeof(DQ_NonQuantitativeAttributeAccuracy), Order = 0)]
    [XmlElement("DQ_PositionalAccuracy", typeof(DQ_PositionalAccuracy), Order = 0)]
    [XmlElement("DQ_QuantitativeAttributeAccuracy", typeof(DQ_QuantitativeAttributeAccuracy), Order = 0)]
    [XmlElement("DQ_RelativeInternalPositionalAccuracy", typeof(DQ_RelativeInternalPositionalAccuracy), Order = 0)]
    [XmlElement("DQ_TemporalAccuracy", typeof(DQ_TemporalAccuracy), Order = 0)]
    [XmlElement("DQ_TemporalConsistency", typeof(DQ_TemporalConsistency), Order = 0)]
    [XmlElement("DQ_TemporalValidity", typeof(DQ_TemporalValidity), Order = 0)]
    [XmlElement("DQ_ThematicAccuracy", typeof(DQ_ThematicAccuracy), Order = 0)]
    [XmlElement("DQ_ThematicClassificationCorrectness", typeof(DQ_ThematicClassificationCorrectness), Order = 0)]
    [XmlElement("DQ_TopologicalConsistency", typeof(DQ_TopologicalConsistency), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
