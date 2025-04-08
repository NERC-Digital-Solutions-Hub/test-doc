
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 02/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="Number_PropertyType">
//   <xs:choice minOccurs="0">
//     <xs:element ref="gco:Real"/>
//     <xs:element ref="gco:Decimal"/>
//     <xs:element ref="gco:Integer"/>
//   </xs:choice>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics {

  [Serializable]
  [XmlType("Number_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Number_PropertyType")]
  public class Number_PropertyType : NilReasonModel {

    #region Public Properties

    private object _item;

    [XmlElement("Decimal", typeof(decimal), Order = 0)]
    [XmlElement("Integer", typeof(string), DataType = "integer", Order = 0)]
    [XmlElement("Real", typeof(double), Order = 0)]
    public object Item {
      get => _item;
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || !_item.Equals(value)) {
          _item = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
