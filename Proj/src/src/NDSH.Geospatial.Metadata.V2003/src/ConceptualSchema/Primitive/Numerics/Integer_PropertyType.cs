
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 28/12/2022, @gisvlasta
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics {

  [Serializable]
  [XmlType("Integer_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Integer_PropertyType")]
  public class Integer_PropertyType : NilReasonModel {

    #region Public Properties

    private string _integer;

    [XmlElement("Integer", DataType = "integer", Order = 0)]
    [JsonProperty("Integer", Order = 0)]
    public string Integer {
      get => _integer;
      set {
        if (_integer == value) {
          return;
        }
        if (_integer == null || !_integer.Equals(value)) {
          _integer = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
