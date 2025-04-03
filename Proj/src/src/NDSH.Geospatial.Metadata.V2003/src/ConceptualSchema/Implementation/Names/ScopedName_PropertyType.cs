
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 02/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names {

  /// </summary>
  [Serializable]
  [XmlType("ScopedName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("ScopedName_PropertyType")]
  public class ScopedName_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ScopedName_PropertyType"/>.
    /// </summary>
    public ScopedName_PropertyType() {
      _scopedName = default; //  new CodeType();
    }

    #endregion

    #region Public Properties

    private CodeType _scopedName;

    [XmlElement("ScopedName", Order = 0)]
    [JsonProperty("ScopedName", Order = 0)]
    public CodeType ScopedName {
      get => _scopedName;
      set {
        if (_scopedName == value) {
          return;
        }
        if (_scopedName == null || !_scopedName.Equals(value)) {
          _scopedName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }


}
