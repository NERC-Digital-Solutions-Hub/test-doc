
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
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="TypeName_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:TypeName"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
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

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names {

  [Serializable]
  [XmlType("TypeName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("TypeName_PropertyType")]
  public class TypeName_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TypeName_PropertyType"/>.
    /// </summary>
    public TypeName_PropertyType() {
      _typeName = default; //  new TypeName_Type();
    }

    #endregion

    #region Public Properties

    private TypeName_Type _typeName;

    [XmlElement("TypeName", Order = 0)]
    [JsonProperty("TypeName", Order = 0)]
    public TypeName_Type TypeName {
      get => _typeName;
      set {
        if (_typeName == value) {
          return;
        }
        if (_typeName == null || !_typeName.Equals(value)) {
          _typeName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
