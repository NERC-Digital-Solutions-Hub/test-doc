
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

  [Serializable]
  [XmlType("LocalName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("LocalName_PropertyType")]
  public class LocalName_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LocalName_PropertyType"/>.
    /// </summary>
    public LocalName_PropertyType() {
      _localName = default; //  new CodeType();
    }

    #endregion

    #region Public Properties

    private CodeType _localName;

    [XmlElement("LocalName", Order = 0)]
    [JsonProperty("LocalName", Order = 0)]
    public CodeType LocalName {
      get => _localName;
      set {
        if (_localName == value) {
          return;
        }
        if (_localName == null || !_localName.Equals(value)) {
          _localName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
