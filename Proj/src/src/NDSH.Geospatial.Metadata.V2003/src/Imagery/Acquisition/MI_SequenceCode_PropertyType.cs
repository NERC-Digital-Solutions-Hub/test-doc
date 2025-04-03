
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 18/01/2023, 18:07, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_SequenceCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_SequenceCode_PropertyType")]
  public class MI_SequenceCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_SequenceCode_PropertyType"/>.
    /// </summary>
    public MI_SequenceCode_PropertyType() {
      _mi_SequenceCode = default; // new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_SequenceCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_SequenceCode", Order = 0)]
    [JsonProperty("MI_SequenceCode", Order = 0)]
    public CodeListValue_Type MI_SequenceCode {
      get {
        return _mi_SequenceCode;
      }
      set {
        if (_mi_SequenceCode == value) {
          return;
        }
        if (_mi_SequenceCode == null || _mi_SequenceCode.Equals(value) != true) {
          _mi_SequenceCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
