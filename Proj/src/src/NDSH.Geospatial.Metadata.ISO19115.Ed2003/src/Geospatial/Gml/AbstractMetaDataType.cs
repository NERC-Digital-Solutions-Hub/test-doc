
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractMetaData"
//          type="gml:AbstractMetaDataType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="AbstractMetaDataType" abstract="true" mixed="true">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence/>
//   <attribute ref="gml:id"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from AbstractMetaDataType to MetaData.

  /// <summary>
  /// Represents the base class for metadata types in GML.
  /// </summary>
  /// <remarks>
  /// This class supports mixed content and includes an optional GML identifier.
  /// <br></br>
  /// Maps to: <c>AbstractMetaDataType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")] // RESOURCE
  //[XmlInclude(typeof(GenericMetaDataType))]
  [IsoType("AbstractMetaDataType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType("AbstractMetaDataType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractMetaDataType")]
  public abstract class AbstractMetaDataType : AbstractMetaData, IId {

    #region IId Interface

    private string _id;

    /// <summary>
    /// Gets/Sets the GML identifier for this metadata element.
    /// </summary>
    //[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "ID")]
    [JsonProperty("id")]
    public string Id {
      get => _id;
      set => SetProperty(ref _id, value);
    }

    #endregion

  }

}
