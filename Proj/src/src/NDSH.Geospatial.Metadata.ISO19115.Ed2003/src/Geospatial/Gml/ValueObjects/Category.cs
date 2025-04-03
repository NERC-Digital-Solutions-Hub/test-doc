
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/02/2023, @gisvlasta
// History           : 21/03/2025, @gisvlasta - Implemented IAssociated interface.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/valueObjects.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="Category" substitutionGroup="gml:AbstractScalarValue" nillable="true">
//   <annotation>
//     <documentation>
//       A gml:Category has an optional XML attribute codeSpace,
//       whose value is a URI which identifies a dictionary,
//       codelist or authority for the term.
//     </documentation>
//   </annotation>
//   <complexType>
//     <simpleContent>
//       <extension base="gml:CodeType">
//         <attribute name="nilReason" type="gml:NilReasonType"/>
//       </extension>
//     </simpleContent>
//   </complexType>
// </element>
// 
// <complexType name="CategoryPropertyType">
//   <sequence minOccurs="0">
//     <element ref="gml:Category"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.ValueObjects {

  /// <summary>
  /// The <see cref="Category"/> has the optional property <see cref="CodeType.CodeSpace">CodeSpace</see>
  /// (XML attribute codeSpace), whose value is a <see cref="Uri"/> which identifies a dictionary,
  /// codelist or authority for the term.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>Category</c> ( /2005/gml/valueObjects.xsd )
  /// </remarks>
  [IsoType("Category", WrapperName = "CategoryPropertyType", IsoType = IsoTypes.Element)]
  //[XmlType("Category", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Category")]
  public class Category : CodeType, IAssociated {

    #region IAssociated Interface

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see>.
    /// </summary>
    public AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

    #endregion

  }

}
