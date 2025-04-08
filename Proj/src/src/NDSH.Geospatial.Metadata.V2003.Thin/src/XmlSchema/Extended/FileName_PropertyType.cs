
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 21:02, @gisvlasta.
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
// <xs:element name="FileName" type="gmx:FileName_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="FileName_PropertyType">
//   <xs:sequence minOccurs="0">
// 	   <xs:element ref="gmx:FileName"/>
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
  [XmlType("FileName_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("FileName_PropertyType")]
  public class FileName_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="FileName_PropertyType"/>.
    /// </summary>
    public FileName_PropertyType() {
      _fileName  = default; //  new FileName_Type();
    }

    #endregion

    #region Public Properties

    private FileName_Type _fileName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FileName", Order = 0)]
    [JsonProperty("FileName", Order = 0)]
    public FileName_Type FileName {
      get {
        return _fileName;
      }
      set {
        if (_fileName == value) {
          return;
        }
        if (_fileName == null || _fileName.Equals(value) != true) {
          _fileName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
