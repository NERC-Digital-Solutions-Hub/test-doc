
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive {

  [Serializable]
  [XmlType("Binary_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Binary_PropertyType")]
  public class Binary_PropertyType : ObservableDbEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Binary_PropertyType"/>.
    /// </summary>
    public Binary_PropertyType() {
      _binary = default; //  new Binary_Type();
    }

    #endregion

    #region Public Properties

    private Binary_Type _binary;

    [XmlElement("Binary", Order = 0)]
    [JsonProperty("Binary", Order = 0)]
    public Binary_Type Binary {
      get => _binary;
      set {
        if (_binary == value) {
          return;
        }
        if (_binary == null || !_binary.Equals(value)) {
          _binary = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
