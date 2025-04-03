
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 23/12/2022, @gisvlasta
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

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Truth {

  [Serializable]
  [XmlType("Boolean_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Boolean_PropertyType")]
  public class Boolean_PropertyType : NilReasonModel { // TODO: IMPORTANT - The name 'CodeList_PropertyType' DOES not make sense for this type. We need to CHANGE the name of CodeList_PropertyType

    #region Public Properties

    private bool _boolean;

    [XmlElement("Boolean", Order = 0)]
    [JsonProperty("Boolean", Order = 0)]
    public bool Boolean {
      get => _boolean;
      set {
        if (!_boolean.Equals(value)) {
          _boolean = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
