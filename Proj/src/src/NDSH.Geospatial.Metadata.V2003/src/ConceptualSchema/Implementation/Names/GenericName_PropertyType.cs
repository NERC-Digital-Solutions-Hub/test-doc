
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
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names {

  [Serializable]
  [XmlType("GenericName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("GenericName_PropertyType")]
  public class GenericName_PropertyType : NilReasonModel { // TODO: GenericName seems to be an abstract? class which has LocalName as its child (ISO 19109:2006, p.12), possibly other childern as well.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GenericName_PropertyType"/>.
    /// </summary>
    public GenericName_PropertyType() {
      _abstractGenericName = default; //  new CodeType();
    }

    #endregion

    #region Public Properties

    private CodeType _abstractGenericName;

    [XmlElement("AbstractGenericName", Order = 0)]
    [JsonProperty("AbstractGenericName", Order = 0)]
    public CodeType AbstractGenericName {
      get => _abstractGenericName;
      set {
        if (_abstractGenericName == value) {
          return;
        }
        if (_abstractGenericName == null || !_abstractGenericName.Equals(value)) {
          _abstractGenericName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
