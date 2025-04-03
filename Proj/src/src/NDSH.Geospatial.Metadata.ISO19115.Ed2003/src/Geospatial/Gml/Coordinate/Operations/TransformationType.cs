
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 26/03/2025, @gisvlasta
// History           : 26/03/2025, @simagyari - Updated code, documentation, and header.
//                   : 26/03/2025, @gisvlasta - Changed List<T> to ObservableCollection<T>, improved documentation and
//                                              updated header.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateOperations.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="method" type="gml:OperationMethodPropertyType">
//   <annotation>
//     <documentation>
//       gml:method is an association role to the operation method used by a coordinate operation.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="usesMethod" type="gml:OperationMethodPropertyType" substitutionGroup="gml:method">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="parameterValue" type="gml:AbstractGeneralParameterValuePropertyType">
//   <annotation>
//     <documentation>
//       gml:parameterValue is a composition association to a parameter value or
//       group of parameter values used by a coordinate operation.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="usesValue"
//          type="gml:AbstractGeneralParameterValuePropertyType" substitutionGroup="gml:parameterValue">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="Transformation" type="gml:TransformationType" substitutionGroup="gml:AbstractGeneralTransformation">
//   <annotation>
//     <documentation>
//       gml:Transformation is a concrete object element derived from gml:GeneralTransformation (13.6.2.13).
//       This concrete object can be used for all operation methods, without using a GML Application Schema
//       that defines operation-method-specialized element names and contents,
//       especially for methods with only one Transformation instance.
//       The parameterValue elements are an unordered list of composition associations to the set of
//       parameter values used by this conversion operation.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="TransformationType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralTransformationType">
//       <sequence>
//         <element ref="gml:method"/>
//         <element ref="gml:parameterValue" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="TransformationPropertyType">
//   <annotation>
//     <documentation>
//       gml:TransformationPropertyType is a property type for association roles to a transformation,
//       either referencing or containing the definition of that transformation.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:Transformation"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  /// <summary>
  ///   <para>
  ///     The <see cref="TransformationType"/> is a concrete object element derived from
  ///     <see cref="AbstractGeneralTransformationType"/> (13.6.2.13).
  ///   </para>
  ///   <para>
  ///     This concrete object can be used for all operation methods, without using a GML Application Schema
  ///     that defines operation-method-specialized element names and contents, especially for methods with
  ///     only one Transformation instance. The parameterValue elements are an unordered list of
  ///     composition associations to the set of parameter values used by this conversion operation.
  ///   </para>
  /// </summary>
  /// <remarks>
  /// Maps to <c>TransformationType</c> ( /2005/gml/coordinateOperations.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_Transformation_Type))] // GMX
  [IsoType("TransformationType", WrapperName = "TransformationPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TransformationType")]
  public class TransformationType : AbstractGeneralTransformationType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TransformationType"/>.
    /// </summary>
    public TransformationType() {
      _parameterValue = [];
    }

    #endregion

    #region Public Properties

    private OperationMethodType _method;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="OperationMethodType"/> used by a coordinate operation.
    /// </summary>
    // [XmlElement(Order = 0)]
    [JsonProperty("method", Order = 0)]
    public OperationMethodType Method {
      get => _method;
      set => SetProperty(ref _method, value);
    }

    private ObservableCollection<AbstractGeneralParameterValueType> _parameterValue;

    /// <summary>
    /// Gets/Sets a composition association to a <see cref="AbstractGeneralParameterValueType">parameter value</see> or
    /// <see cref="ObservableCollection{AbstractGeneralParameterValueType}">group of parameter values</see>
    /// used by a coordinate operation.
    /// </summary>
    /// <remarks>
    /// A parameter value is encoded as an <see cref="ObservableCollection{AbstractGeneralParameterValueType}"/>
    /// which has only one <see cref="AbstractGeneralParameterValueType"/> concrete instance.
    /// </remarks>
    // [XmlElement("parameterValue", Order = 1)]
    [JsonProperty("parameterValue", Order = 1)]
    public ObservableCollection<AbstractGeneralParameterValueType> ParameterValue {
      get => _parameterValue;
      set => SetProperty(ref _parameterValue, value);
    }

    #endregion

  }

}
