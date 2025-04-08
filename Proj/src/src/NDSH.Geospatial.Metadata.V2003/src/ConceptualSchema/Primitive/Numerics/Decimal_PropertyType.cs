
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics {

  [Serializable]
  [XmlType("Decimal_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Decimal_PropertyType")]
  public class Decimal_PropertyType : NilReasonModel {

    #region Public Properties

    private decimal _decimal;

    [XmlElement("Decimal", Order = 0)]
    [JsonProperty("Decimal", Order = 0)]
    public decimal Decimal {
      get => _decimal;
      set {
        if (!_decimal.Equals(value)) {
          _decimal = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
