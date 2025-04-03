
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:40, @gisvlasta.
// Updated by        : 09/01/2023, 19:3365, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Common;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_RepresentativeFraction", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_RepresentativeFraction", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_RepresentativeFraction")]
  public class MD_RepresentativeFraction_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_RepresentativeFraction_Type"/>.
    /// </summary>
    public MD_RepresentativeFraction_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _denominator  = default; //  new Integer_PropertyType();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private Integer_PropertyType _denominator;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("denominator", Order = 0)]
    [JsonProperty("denominator", Order = 0)]
    public Integer_PropertyType Denominator {
      get {
        return _denominator;
      }
      set {
        if (_denominator == value) {
          return;
        }
        if (_denominator == null || _denominator.Equals(value) != true) {
          _denominator = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
