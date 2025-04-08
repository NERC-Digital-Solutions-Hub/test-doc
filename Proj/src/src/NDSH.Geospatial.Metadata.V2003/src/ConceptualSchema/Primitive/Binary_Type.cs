
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

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive {

  [Serializable]
  [XmlType("Binary", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Binary")]
  public class Binary_Type : ObservableModel { // TODO: Only Model???

    #region Public Properties

    private string _src;

    [XmlAttribute("src", DataType = "anyURI")]
    [JsonProperty("src")]
    public string Src {
      get => _src;
      set {
        if (_src == value) {
          return;
        }
        if (_src == null || !_src.Equals(value)) {
          _src = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    [XmlText(DataType = "string")]
    [JsonProperty("Value")]
    public string Value {
      get => _value;
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || !_value.Equals(value)) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
