
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/01/2023, 02:23, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmx/extendedTypes.xsd
// --------------------------------------------------------------------------------
// <xs:element name="Anchor" type="gmx:Anchor_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="Anchor_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:Anchor"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Extended {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Anchor_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("Anchor_PropertyType")]
  public class Anchor_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Anchor_PropertyType"/>.
    /// </summary>
    public Anchor_PropertyType() {
      _anchor  = default; //  new Anchor_Type();
    }

    #endregion

    #region Public Properties

    private Anchor_Type _anchor;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Anchor", Order = 0)]
    [JsonProperty("Anchor", Order = 0)]
    public Anchor_Type Anchor {
      get {
        return _anchor;
      }
      set {
        if (_anchor == value) {
          return;
        }
        if (_anchor == null || _anchor.Equals(value) != true) {
          _anchor = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
