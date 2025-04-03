
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 20:32, @gisvlasta.
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
// <xs:element name="RecordType" type="gco:RecordType_Type"/>
// <xs:complexType name="RecordType_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:RecordType"/>
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Records {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("RecordType_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("RecordType_PropertyType")]
  public class RecordType_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="RecordType_PropertyType"/>.
    /// </summary>
    public RecordType_PropertyType() {
      _recordType  = default; //  new RecordType_Type();
    }

    #endregion

    #region Public Properties

    private RecordType_Type _recordType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("RecordType", Order = 0)]
    [JsonProperty("RecordType", Order = 0)]
    public RecordType_Type RecordType {
      get {
        return _recordType;
      }
      set {
        if (_recordType == value) {
          return;
        }
        if (_recordType == null || _recordType.Equals(value) != true) {
          _recordType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}