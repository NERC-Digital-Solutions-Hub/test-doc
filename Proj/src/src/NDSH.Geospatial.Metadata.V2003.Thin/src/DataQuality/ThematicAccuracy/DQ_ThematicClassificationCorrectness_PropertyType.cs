
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:55, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.ThematicAccuracy {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_ThematicClassificationCorrectness_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_ThematicClassificationCorrectness_PropertyType")]
  public class DQ_ThematicClassificationCorrectness_PropertyType : ObjectReference_PropertyType
  {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_ThematicClassificationCorrectness_PropertyType"/>.
    /// </summary>
    public DQ_ThematicClassificationCorrectness_PropertyType()
    {
      _dq_ThematicClassificationCorrectness = new DQ_ThematicClassificationCorrectness_Type();
    }

    #endregion

    #region Public Properties

    private DQ_ThematicClassificationCorrectness_Type _dq_ThematicClassificationCorrectness;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_ThematicClassificationCorrectness", Order = 0)]
    [JsonProperty("DQ_ThematicClassificationCorrectness", Order = 0)]
    public DQ_ThematicClassificationCorrectness_Type DQ_ThematicClassificationCorrectness
    {
      get
      {
        return _dq_ThematicClassificationCorrectness;
      }
      set
      {
        if (_dq_ThematicClassificationCorrectness == value)
        {
          return;
        }
        if (_dq_ThematicClassificationCorrectness == null || _dq_ThematicClassificationCorrectness.Equals(value) != true)
        {
          _dq_ThematicClassificationCorrectness = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
