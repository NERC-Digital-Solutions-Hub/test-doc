
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/01/2023, 02:12, @gisvlasta.
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
// <xs:element name="MimeFileType" type="gmx:MimeFileType_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MimeFileType_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:MimeFileType"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Extended {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MimeFileType_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("MimeFileType_PropertyType")]
  public class MimeFileType_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MimeFileType_PropertyType"/>.
    /// </summary>
    public MimeFileType_PropertyType() {
      _mimeFileType  = default; //  new MimeFileType_Type();
    }

    #endregion

    #region Public Properties

    private MimeFileType_Type _mimeFileType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MimeFileType", Order = 0)]
    [JsonProperty("MimeFileType", Order = 0)]
    public MimeFileType_Type MimeFileType {
      get {
        return _mimeFileType;
      }
      set {
        if (_mimeFileType == value) {
          return;
        }
        if (_mimeFileType == null || _mimeFileType.Equals(value) != true) {
          _mimeFileType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
