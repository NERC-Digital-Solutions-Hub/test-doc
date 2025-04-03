
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics {

  [Serializable]
  [XmlType("UnlimitedInteger_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UnlimitedInteger_PropertyType")]
  public class UnlimitedInteger_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UnlimitedInteger_PropertyType"/>.
    /// </summary>
    public UnlimitedInteger_PropertyType() {
      _unlimitedInteger = default; //  new UnlimitedInteger_Type();
    }

    #endregion

    #region Private fields

    private UnlimitedInteger_Type _unlimitedInteger;

    [XmlElement("UnlimitedInteger", IsNullable = true, Order = 0)]
    [JsonProperty("UnlimitedInteger", Order = 0)]
    public UnlimitedInteger_Type UnlimitedInteger {
      get => _unlimitedInteger;
      set {
        if (_unlimitedInteger == value) {
          return;
        }
        if (_unlimitedInteger == null || !_unlimitedInteger.Equals(value)) {
          _unlimitedInteger = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
