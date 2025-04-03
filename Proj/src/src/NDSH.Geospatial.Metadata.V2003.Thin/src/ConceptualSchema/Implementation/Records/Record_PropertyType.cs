
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 16:33, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/basicTypes.xsd
// --------------------------------------------------------------------------------
// <xs:element name="Record"/>
// <xs:complexType name="Record_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Record"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Records {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Record_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Record_PropertyType")]
  public class Record_PropertyType : ObjectReference_PropertyType {
    
    #region Public Properties

    private object _record;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Record", Order = 0)]
    [JsonProperty("Record", Order = 0)]
    public object Record {
      get {
        return _record;
      }
      set {
        if (_record == value) {
          return;
        }
        if (_record == null || _record.Equals(value) != true) {
          _record = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
