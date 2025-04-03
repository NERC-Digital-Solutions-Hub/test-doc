
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:43, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractTimeGeometricPrimitive" type="gml:AbstractTimeGeometricPrimitiveType" abstract="true" substitutionGroup="gml:AbstractTimePrimitive">
//   <annotation>
//     <documentation>
//       gml:TimeGeometricPrimitive acts as the head of a substitution group for geometric temporal primitives.
//       A temporal geometry shall be associated with a temporal reference system through the frame attribute that
//       provides a URI reference that identifies a description of the reference system. Following ISO 19108, the
//       Gregorian calendar with UTC is the default reference system, but others may also be used. The GPS calendar is
//       an alternative reference systems in common use.
//       The two geometric primitives in the temporal dimension are the instant and the period.
//       GML components are defined to support these as follows.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractTimeGeometricPrimitiveType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTimePrimitiveType">
//       <attribute name="frame" type="anyURI" default="#ISO-8601"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  //[XmlInclude(typeof(TimePeriodType))]
  //[XmlInclude(typeof(TimeInstantType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeGeometricPrimitiveType")]
  public abstract class AbstractTimeGeometricPrimitiveType : AbstractTimePrimitiveType {
    #region Private fields
    private string _frame;
    #endregion

    /// <summary>
    /// AbstractTimeGeometricPrimitiveType class constructor
    /// </summary>
    public AbstractTimeGeometricPrimitiveType() {
      _frame = "#ISO-8601";
    }

    [XmlAttribute(DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    [JsonProperty("frame")]
    public string Frame {
      get {
        return _frame;
      }
      set {
        if (_frame == value) {
          return;
        }
        if (_frame == null || _frame.Equals(value) != true) {
          _frame = value;
          OnPropertyChanged("Frame");
        }
      }
    }
  }

}
