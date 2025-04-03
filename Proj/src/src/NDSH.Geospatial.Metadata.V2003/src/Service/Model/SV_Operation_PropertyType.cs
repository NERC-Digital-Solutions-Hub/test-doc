
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 02:27, @gisvlasta.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_Operation_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_Operation_PropertyType")]
  public class SV_Operation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Operation_PropertyType"/>.
    /// </summary>
    public SV_Operation_PropertyType() {
      _sv_Operation = new SV_Operation_Type();
    }

    #endregion

    #region Public Properties

    private SV_Operation_Type _sv_Operation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_Operation", Order = 0)]
    [JsonProperty("SV_Operation", Order = 0)]
    public SV_Operation_Type SV_Operation {
      get {
        return _sv_Operation;
      }
      set {
        if (_sv_Operation == value) {
          return;
        }
        if (_sv_Operation == null || _sv_Operation.Equals(value) != true) {
          _sv_Operation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
