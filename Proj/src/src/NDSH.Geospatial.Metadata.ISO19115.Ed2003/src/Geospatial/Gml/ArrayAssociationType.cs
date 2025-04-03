
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 09/03/2025, @gisvlasta - Changed the inheritance and implementation of the class.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="ArrayAssociationType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence>
//     <element ref="gml:AbstractObject" minOccurs="0" maxOccurs="unbounded"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// 
// <element name="members" type="gml:ArrayAssociationType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from ArrayAssociationType to ArrayAssociation or GmlArrayAssociation.

  /// <summary>
  /// Represents an association to an array of GML objects.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>ArrayAssociationType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")] // RESOURCE
  [IsoType("ArrayAssociationType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("ArrayAssociationType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArrayAssociationType")]
  public class ArrayAssociationType : AbstractMemberType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ArrayAssociationType"/>.
    /// </summary>
    public ArrayAssociationType() {
      _abstractObject = default; //  new List<object>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<GmlObject> _abstractObject;

    /// <summary>
    /// Gets/Sets the <see cref="ObservableCollection{AbstractObject}"/> of associated GML objects.
    /// </summary>
    /// <remarks>
    /// The <see cref="AbstractObject"/> elements in the XSD,
    /// allowing for multiple GML objects to be referenced.
    /// </remarks>
    //[XmlElement("AbstractObject", Order = 0)]
    [JsonProperty("abstractObject", Order = 0)]
    public ObservableCollection<GmlObject> AbstractObject {
      get => _abstractObject;
      set {
        if (_abstractObject == value) {
          return;
        }
        if (_abstractObject == null || _abstractObject.Equals(value) != true) {
          _abstractObject = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
