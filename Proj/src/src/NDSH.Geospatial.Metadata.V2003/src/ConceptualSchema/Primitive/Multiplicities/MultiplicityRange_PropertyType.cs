
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
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

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Multiplicities {

  [Serializable]
  [XmlType("MultiplicityRange_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("MultiplicityRange_PropertyType")]
  public class MultiplicityRange_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MultiplicityRange_PropertyType"/>.
    /// </summary>
    public MultiplicityRange_PropertyType() {
      _multiplicityRange = new MultiplicityRange_Type();
    }

    #endregion

    #region Public Properties

    private MultiplicityRange_Type _multiplicityRange;

    [XmlElement("MultiplicityRange", Order = 0)]
    [JsonProperty("MultiplicityRange", Order = 0)]
    public MultiplicityRange_Type MultiplicityRange {
      get => _multiplicityRange;
      set {
        if (_multiplicityRange == value) {
          return;
        }
        if (_multiplicityRange == null || !_multiplicityRange.Equals(value)) {
          _multiplicityRange = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
