
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 05/03/2025, @gisvlasta - Polished class.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : This class is fully documented in ISO 19109.
// ---------------------------------------------------------------------------------------------------------------------
// Advised that the following are properties of the GF_AttributeType
// --------
// - name:        Inherited from GF_PropertyType.
// - type:        Inherited from GF_PropertyType.
// - cardinality: Inherited from GF_PropertyType.
// - definition:  Inherited from GF_PropertyType.
// - valueDomain: Specifies the permissible values for the attribute.
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Multiplicities;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic
  // WARNING: Compare properties with the advisable ones.

  /// <summary>
  /// Class of attribute definitions of a feature type.
  /// </summary>
  [Serializable()]
  //[XmlType(AnonymousType = false)]
  //[XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_AttributeType : GF_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_AttributeType"/>.
    /// </summary>
    public GF_AttributeType() {
      _valueType = default;
      _valueDomain = default;
      _cardinality = default;
    }

    #endregion

    #region Public Properties

    // WARNING: Check which properties need to be nullable.

    private TypeName_Type _valueType;

    //[XmlElement("valueType", Order = 0)]
    [JsonProperty("valueType", Order = 0)]
    public TypeName_Type ValueType {
      get => _valueType;
      set => SetProperty(ref _valueType, value);
    }

    private CharacterString _valueDomain;

    //[XmlElement("valueDomain", Order = 1)]
    [JsonProperty("valueDomain", Order = 1)]
    public CharacterString ValueDomain {
      get => _valueDomain;
      set => SetProperty(ref _valueDomain, value);
    }

    private Multiplicity_Type _cardinality;

    //[XmlElement("cardinality", Order = 2)]
    [JsonProperty("cardinality", Order = 2)]
    public Multiplicity_Type Cardinality {
      get => _cardinality;
      set => SetProperty(ref _cardinality, value);
    }

    #endregion

    // TODO: Characterize Attribute is documented in UML diagrams. What should be done here?
    // CHRIS: Characterize Attribute is no need to implement here. The relationship is captured by the MD_Metadata's _featureAttribute, see MD_Medata_Type.cs.

    // private GF_AttributeType _characterize;

    ///// <summary>
    ///// 
    ///// </summary>    
    //public GF_AttributeType Characterize {
    //  get {
    //    return _characterize;
    //  }
    //  set {
    //    _characterize = value;
    //  }
    //}

    //private PF_PortrayalRule[] ruleField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("rule")]
    //public PF_PortrayalRule[] rule {
    //  get {
    //    return ruleField;
    //  }
    //  set {
    //    ruleField = value;
    //  }
    //}

  }

}
