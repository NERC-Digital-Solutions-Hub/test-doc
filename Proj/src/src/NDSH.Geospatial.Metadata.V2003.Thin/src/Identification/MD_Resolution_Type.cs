
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:46, @gisvlasta.
// Updated by        : 09/01/2023, 19:36, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmd/identification.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="MD_Resolution_Type">
//   <xs:choice>
//     <xs:element name="equivalentScale" type="gmd:MD_RepresentativeFraction_PropertyType"/>
//     <xs:element name="distance" type="gco:Distance_PropertyType"/>
//   </xs:choice>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Derived.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Resolution", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Resolution", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Resolution")]
  public class MD_Resolution_Type : Model { // TODO: DANGER !!! - Make sure this is its inheritance

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Resolution_Type"/>.
    /// </summary>
    public MD_Resolution_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private object _item;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distance", typeof(Distance_PropertyType), Order = 0)]
    [XmlElement("equivalentScale", typeof(MD_RepresentativeFraction_PropertyType), Order = 0)]
    public object Item { // TODO: DANGER !!! - This does not follow the pattern !!!
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
