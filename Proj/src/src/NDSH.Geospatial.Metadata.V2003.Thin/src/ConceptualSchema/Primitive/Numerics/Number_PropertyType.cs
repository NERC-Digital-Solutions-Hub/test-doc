
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 20:19, @gisvlasta.
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
// <xs:complexType name="Number_PropertyType">
//   <xs:choice minOccurs="0">
//     <xs:element ref="gco:Real"/>
//     <xs:element ref="gco:Decimal"/>
//     <xs:element ref="gco:Integer"/>
//   </xs:choice>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Number_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Number_PropertyType")]
  public class Number_PropertyType : NilReasonModel {
    
    #region Public Properties

    private object _item;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Decimal", typeof(decimal), Order = 0)]
    [XmlElement("Integer", typeof(string), DataType = "integer", Order = 0)]
    [XmlElement("Real", typeof(double), Order = 0)]
    public object Item {
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
