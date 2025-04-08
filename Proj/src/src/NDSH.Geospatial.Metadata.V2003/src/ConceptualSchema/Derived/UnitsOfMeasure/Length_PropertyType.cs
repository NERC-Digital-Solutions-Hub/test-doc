
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 02/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Derived.UnitsOfMeasure {

  [Serializable]
  [XmlType("Length_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Length_PropertyType")]
  public class Length_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Length_PropertyType"/>.
    /// </summary>
    public Length_PropertyType() {
      _length = default; //  new LengthType();
    }

    #endregion

    #region Public Properties

    private LengthType _length;

    [XmlElement("Length", Order = 0)]
    [JsonProperty("Length", Order = 0)]
    public LengthType Length {
      get => _length;
      set {
        if (_length == value) {
          return;
        }
        if (_length == null || !_length.Equals(value)) {
          _length = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
