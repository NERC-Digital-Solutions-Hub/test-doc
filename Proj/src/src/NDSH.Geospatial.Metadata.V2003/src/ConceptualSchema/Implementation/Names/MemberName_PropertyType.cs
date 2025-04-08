
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names {

  [Serializable]
  [XmlType("MemberName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("MemberName_PropertyType")]
  public class MemberName_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MemberName_PropertyType"/>.
    /// </summary>
    public MemberName_PropertyType() {
      _memberName = default; //  new MemberName_Type();
    }

    #endregion

    #region Public Properties

    private MemberName_Type _memberName;

    [XmlElement("MemberName", Order = 0)]
    [JsonProperty("MemberName", Order = 0)]
    public MemberName_Type MemberName {
      get => _memberName;
      set {
        if (_memberName == value) {
          return;
        }
        if (_memberName == null || !_memberName.Equals(value)) {
          _memberName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
