
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 20:24, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="ClothoidType">
//   <complexContent>
//     <extension base="gml:AbstractCurveSegmentType">
//       <sequence>
//         <element name="refLocation">
//           <complexType>
//             <sequence>
//               <element ref="gml:AffinePlacement"/>
//             </sequence>
//           </complexType>
//         </element>
//         <element name="scaleFactor" type="decimal"/>
//         <element name="startParameter" type="double"/>
//         <element name="endParameter" type="double"/>
//       </sequence>
//       <attribute name="interpolation" type="gml:CurveInterpolationType" fixed="clothoid"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Clothoid" type="gml:ClothoidType" substitutionGroup="gml:AbstractCurveSegment">
//   <annotation>
//     <documentation>
//       A clothoid, or Cornu's spiral, is plane curve whose curvature is a fixed function of its length.
//       refLocation, startParameter, endParameter and scaleFactor have the same meaning as specified in ISO 19107:2003, 6.4.22.
//       interpolation is fixed as "clothoid".
//       The content model follows the general pattern for the encoding of curve segments.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ClothoidType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ClothoidType")]
  public class ClothoidType : AbstractCurveSegmentType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ClothoidType"/>.
    /// </summary>
    public ClothoidType() {
      _refLocation = new ClothoidTypeRefLocation();
      _interpolation = CurveInterpolationType.clothoid;
    }

    #endregion

    #region Public Properties

    private ClothoidTypeRefLocation _refLocation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("refLocation", Order = 0)]
    [JsonProperty("refLocation", Order = 0)]
    public ClothoidTypeRefLocation RefLocation {
      get {
        return _refLocation;
      }
      set {
        if (_refLocation == value) {
          return;
        }
        if (_refLocation == null || _refLocation.Equals(value) != true) {
          _refLocation = value;
          OnPropertyChanged();
        }
      }
    }

    private decimal _scaleFactor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scaleFactor", Order = 1)]
    [JsonProperty("scaleFactor", Order = 1)]
    public decimal ScaleFactor {
      get {
        return _scaleFactor;
      }
      set {
        if (_scaleFactor.Equals(value) != true) {
          _scaleFactor = value;
          OnPropertyChanged();
        }
      }
    }

    private double _startParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("startParameter", Order = 2)]
    [JsonProperty("startParameter", Order = 2)]
    public double StartParameter {
      get {
        return _startParameter;
      }
      set {
        if (_startParameter.Equals(value) != true) {
          _startParameter = value;
          OnPropertyChanged();
        }
      }
    }

    private double _endParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("endParameter", Order = 3)]
    [JsonProperty("endParameter", Order = 3)]
    public double EndParameter {
      get {
        return _endParameter;
      }
      set {
        if (_endParameter.Equals(value) != true) {
          _endParameter = value;
          OnPropertyChanged();
        }
      }
    }

    private CurveInterpolationType _interpolation;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("interpolation")]
    [JsonProperty("interpolation")]
    public CurveInterpolationType Interpolation {
      get {
        return _interpolation;
      }
      set {
        if (_interpolation.Equals(value) != true) {
          _interpolation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
