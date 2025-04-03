
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

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics {

  [Serializable]
  [XmlType("UnlimitedInteger", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UnlimitedInteger")]
  public class UnlimitedInteger_Type : ObservableModel {

    #region Public Properties

    private bool _isInfinite;

    [XmlAttribute("isInfinite")]
    [JsonProperty("isInfinite")]
    public bool IsInfinite {
      get => _isInfinite;
      set {
        if (!_isInfinite.Equals(value)) {
          _isInfinite = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    [XmlText(DataType = "nonNegativeInteger")]
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
