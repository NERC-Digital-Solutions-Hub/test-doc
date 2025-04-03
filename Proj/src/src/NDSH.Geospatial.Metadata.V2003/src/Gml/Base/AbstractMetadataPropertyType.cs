
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 03:12, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// XSD               : /2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <complexType name="AbstractMetadataPropertyType" abstract="true">
//   <sequence/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Base {

  /// <summary>
  /// To associate metadata described by any XML Schema with a GML object, a property element shall be defined whose content model is derived by extension from gml:AbstractMetadataPropertyType.
  /// The value of such a property shall be metadata. The content model of such a property type, i.e. the metadata application schema shall be specified by the GML Application Schema.
  /// By default, this abstract property type does not imply any ownership of the metadata. The owns attribute of gml:OwnershipAttributeGroup may be used on a metadata property element instance to assert ownership of the metadata.
  /// If metadata following the conceptual model of ISO 19115 is to be encoded in a GML document, the corresponding Implementation Specification specified in ISO/TS 19139 shall be used to encode the metadata information.
  /// </summary>
  [Serializable]
  [XmlType("AbstractMetadataPropertyType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractMetadataPropertyType")]
  public abstract class AbstractMetadataPropertyType : ObservableModel, IOwnershipAttributeGroup { // TODO: Extract the correct Interfaces / abstract classes.

    #region Constructors - Destructors

    /// <summary>
    /// Initialize the <see cref="AbstractMetadataPropertyType"/>.
    /// </summary>
    public AbstractMetadataPropertyType() {
      _owns = default; //  false;
    }

    #endregion

    #region Public Properties

    private bool _owns;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("owns")]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
