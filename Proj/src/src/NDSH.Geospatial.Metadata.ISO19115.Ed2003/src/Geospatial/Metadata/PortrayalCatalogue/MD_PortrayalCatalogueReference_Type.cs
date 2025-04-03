
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/portrayalCatalogue.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_PortrayalCatalogueReference_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="portrayalCatalogueCitation" type="gmd:CI_Citation_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_PortrayalCatalogueReference" type="gmd:MD_PortrayalCatalogueReference_Type"/>
// <xs:complexType name="MD_PortrayalCatalogueReference_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_PortrayalCatalogueReference"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Citation;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.PortrayalCatalogue {

  /// <summary>
  /// Information identifying the portrayal catalogue used.
  /// </summary>
  [Serializable]
  //[XmlType("MD_PortrayalCatalogueReference", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_PortrayalCatalogueReference", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_PortrayalCatalogueReference")]
  public class MD_PortrayalCatalogueReference_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_PortrayalCatalogueReference_Type"/>.
    /// </summary>
    public MD_PortrayalCatalogueReference_Type() {
      _portrayalCatalogueCitation = default; //  new List<CI_Citation_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CI_Citation_Type> _portrayalCatalogueCitation;

    /// <summary>
    /// Bibliographic reference to the portrayal catalogue cited.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("portrayalCatalogueCitation", Order = 0)]
    [JsonProperty("portrayalCatalogueCitation", Order = 0)]
    public ObservableCollection<CI_Citation_Type> PortrayalCatalogueCitation {
      get => _portrayalCatalogueCitation;
      set => SetProperty(ref _portrayalCatalogueCitation, value);
    }

    #endregion

  }

}
