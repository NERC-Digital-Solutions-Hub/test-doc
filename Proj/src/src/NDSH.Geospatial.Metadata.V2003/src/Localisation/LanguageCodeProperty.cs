
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 13/02/2023, 04:24, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmd/freeText.xsd
// --------------------------------------------------------------------------------
// <xs:element name="LanguageCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="LanguageCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:LanguageCode"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Localisation {

  // TODO: REMOVE THIS CLASS

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LanguageCode", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("LanguageCode")]
  public class LanguageCodeProperty : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LanguageCodeProperty"/>.
    /// </summary>
    public LanguageCodeProperty() {

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

    private CodeListValueItem _languageCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LanguageCode", Order = 0)]
    [JsonProperty("LanguageCode", Order = 0)]
    public CodeListValueItem LanguageCode { // WARNING: Why do we use CodeListValueItem here?
      get {
        return _languageCode;
      }
      set {
        if (_languageCode == value) {
          return;
        }
        if (_languageCode == null || _languageCode.Equals(value) != true) {
          _languageCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
