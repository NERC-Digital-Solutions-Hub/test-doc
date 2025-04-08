
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Common.Extent {

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
      _ex_GeographicDescription = default; //  new EX_GeographicDescription_Type();
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
      get => _ex_GeographicDescription;
      set {
        if (_ex_GeographicDescription == value) {
          return;
        }
        if (_ex_GeographicDescription == null || !_ex_GeographicDescription.Equals(value)) {
          _ex_GeographicDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
