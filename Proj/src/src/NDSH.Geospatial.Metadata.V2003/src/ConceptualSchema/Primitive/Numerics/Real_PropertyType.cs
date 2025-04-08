
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics {

  [Serializable]
  [XmlType("Real_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Real_PropertyType")]
  public class Real_PropertyType : NilReasonModel {

    #region Public Properties

    private double _real;

    [XmlElement("Real", DataType = "decimal", Order = 0)]
    [JsonProperty("Real", Order = 0)]
    public double Real {
      get => _real;
      set {
        if (!_real.Equals(value)) {
          _real = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
