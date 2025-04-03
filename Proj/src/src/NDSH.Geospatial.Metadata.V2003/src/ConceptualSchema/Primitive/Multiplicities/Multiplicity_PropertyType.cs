
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
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

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Multiplicities {

  [Serializable]
  [XmlType("Multiplicity_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Multiplicity_PropertyType")]
  public class Multiplicity_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Multiplicity_PropertyType"/>.
    /// </summary>
    public Multiplicity_PropertyType() {
      _multiplicity = new Multiplicity_Type();
    }

    #endregion

    #region Public Properties

    private Multiplicity_Type _multiplicity;

    [XmlElement("Multiplicity", Order = 0)]
    [JsonProperty("Multiplicity", Order = 0)]
    public Multiplicity_Type Multiplicity {
      get => _multiplicity;
      set {
        if (_multiplicity == value) {
          return;
        }
        if (_multiplicity == null || !_multiplicity.Equals(value)) {
          _multiplicity = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
