
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 18:43, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
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

namespace NDSH.Geospatial.Metadata.V2003.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable()]
  [XmlType(AnonymousType = false)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_PropertyType { // TODO: Model???

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_PropertyType"/>.
    /// </summary>
    public GF_PropertyType() {
    
    }

    #endregion

    #region Public Properties

    private LocalName_PropertyType _memberName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("memberName")]
    public LocalName_PropertyType MemberName {
      get {
        return _memberName;
      }
      set {
        _memberName = value;
      }
    }

    private CharacterString_PropertyType _definition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("definition")]
    public CharacterString_PropertyType Definition {
      get {
        return _definition;
      }
      set {
        _definition = value;
      }
    }

    private List<GF_Constraint_PropertyType> _constrainedBy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("constrainedBy")]
    public List<GF_Constraint_PropertyType> ConstrainedBy {
      get {
        return _constrainedBy;
      }
      set {
        _constrainedBy = value;
      }
    }

    #endregion


    //private GF_Constraint[] constrainedByField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("constrainedBy")]
    //public GF_Constraint[] constrainedBy {
    //  get {
    //    return constrainedByField;
    //  }
    //  set {
    //    constrainedByField = value;
    //  }
    //}

    //private MD_Metadata[] featureAttributeMetadataField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("featureAttributeMetadata")]
    //public MD_Metadata[] featureAttributeMetadata {
    //  get {
    //    return featureAttributeMetadataField;
    //  }
    //  set {
    //    featureAttributeMetadataField = value;
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