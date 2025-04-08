
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 07/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/catalogues.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CT_UomCatalogue_Type">
//   <xs:complexContent>
//     <xs:extension base="gmx:AbstractCT_Catalogue_Type">
//       <xs:sequence>
//         <xs:element name="uomItem" type="gmx:UnitDefinition_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CT_UomCatalogue" type="gmx:CT_UomCatalogue_Type" substitutionGroup="gmx:AbstractCT_Catalogue"/>
// <xs:complexType name="CT_UomCatalogue_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:CT_UomCatalogue"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues {

  [Serializable]
  //[XmlType("CT_UomCatalogue", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("CT_UomCatalogue", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CT_UomCatalogue")]
  public class CT_UomCatalogue_Type : AbstractCT_Catalogue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_UomCatalogue_Type"/>.
    /// </summary>
    public CT_UomCatalogue_Type() {
      _uomItem = default; //  new List<ML_UnitDefinition_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<ML_UnitDefinition_Type> _uomItem;

    /// <summary>
    /// Provides the list of unit of measure items described in the catalogue.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("uomItem", Order = 0)]
    [JsonProperty("uomItem", Order = 0)]
    public ObservableCollection<ML_UnitDefinition_Type> UomItem {
      get => _uomItem;
      set => SetProperty(ref _uomItem, value);
    }

    #endregion

  }

}
