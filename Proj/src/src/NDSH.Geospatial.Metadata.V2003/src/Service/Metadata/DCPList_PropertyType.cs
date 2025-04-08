
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 03:43, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DCPList_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("DCPList_PropertyType")]
  public class DCPList_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DCPList_PropertyType"/>.
    /// </summary>
    public DCPList_PropertyType() {
      _dcpList = new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _dcpList;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DCPList", Order = 0)]
    [JsonProperty("DCPList", Order = 0)]
    public CodeListValue_Type DCPList {
      get {
        return _dcpList;
      }
      set {
        if (_dcpList == value) {
          return;
        }
        if (_dcpList == null || _dcpList.Equals(value) != true) {
          _dcpList = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
