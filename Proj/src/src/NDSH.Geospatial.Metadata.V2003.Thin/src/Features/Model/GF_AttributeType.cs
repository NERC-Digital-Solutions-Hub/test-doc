
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2022, 19:58, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Multiplicities;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable()]
  [XmlType(AnonymousType = false)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_AttributeType : GF_PropertyType {

    #region Public Properties

    private TypeName_PropertyType _valueType;

    /// <summary>
    /// 
    /// </summary>
    public TypeName_PropertyType ValueType {
      get {
        return _valueType;
      }
      set {
        _valueType = value;
      }
    }

    private CharacterString _valueDomain;

    /// <summary>
    /// 
    /// </summary>
    public CharacterString ValueDomain {
      get {
        return _valueDomain;
      }
      set {
        _valueDomain = value;
      }
    }

    private Multiplicity_PropertyType _cardinality;

    /// <summary>
    /// 
    /// </summary>
    public Multiplicity_PropertyType Cardinality {
      get {
        return _cardinality;
      }
      set {
        _cardinality = value;
      }
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
