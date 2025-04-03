
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 19:58, @gisvlasta.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("EX_GeographicDescription_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_GeographicDescription_PropertyType")]
  public class EX_GeographicDescription_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_GeographicDescription_PropertyType"/>.
    /// </summary>
    public EX_GeographicDescription_PropertyType() {
      _ex_GeographicDescription  = default; //  new EX_GeographicDescription_Type();
    }

    #endregion

    #region Public Properties

    private EX_GeographicDescription_Type _ex_GeographicDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_GeographicDescription", Order = 0)]
    [JsonProperty("EX_GeographicDescription", Order = 0)]
    public EX_GeographicDescription_Type EX_GeographicDescription {
      get {
        return _ex_GeographicDescription;
      }
      set {
        if (_ex_GeographicDescription == value) {
          return;
        }
        if (_ex_GeographicDescription == null || _ex_GeographicDescription.Equals(value) != true) {
          _ex_GeographicDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}