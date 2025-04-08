
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 20:01, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// --------------------------------------------------------------------------------
// <xs:element name="DateTime" type="xs:dateTime"/>
// <xs:complexType name="DateTime_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:DateTime"/>
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DateTime_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("DateTime_PropertyType")]
  public class DateTime_PropertyType : NilReasonModel {
    
    #region Public Properties

    private System.DateTime _dateTime;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DateTime", Order = 0)]
    [JsonProperty("DateTime", Order = 0)]
    public System.DateTime DateTime {
      get {
        return _dateTime;
      }
      set {
        if (_dateTime.Equals(value) != true) {
          _dateTime = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
