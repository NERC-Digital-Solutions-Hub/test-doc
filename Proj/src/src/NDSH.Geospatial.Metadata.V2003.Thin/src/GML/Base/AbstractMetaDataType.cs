
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 02:43, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : This class is Deprecated.
// XSD               : 2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <element name="AbstractMetaData" type="gml:AbstractMetaDataType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// <complexType name="AbstractMetaDataType" abstract="true" mixed="true">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence/>
//   <attribute ref="gml:id"/>
// </complexType>
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
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Base {

  /// <summary>
  /// 
  /// </summary>
  [Obsolete()]
  [XmlInclude(typeof(GenericMetaDataType))]
  [Serializable]
  [XmlType("AbstractMetaDataType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractMetaDataType")]
  public abstract class AbstractMetaDataType : Model, IId { // TODO: Extract the correct Interfaces / abstract clases.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMetaDataType"/>.
    /// </summary>
    public AbstractMetaDataType() {
      _text  = default; //  new List<string>();
    }

    #endregion

    #region Public Properties

    private List<string> _text;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlText]
    [JsonProperty("Text")]
    public List<string> Text {
      get {
        return _text;
      }
      set {
        if (_text == value) {
          return;
        }
        if (_text == null || _text.Equals(value) != true) {
          _text = value;
          OnPropertyChanged();
        }
      }
    }

    private int _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "ID")]
    [JsonProperty("id")]
    public int Id {
      get {
        return _id;
      }
      set {
        if (_id != value) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}