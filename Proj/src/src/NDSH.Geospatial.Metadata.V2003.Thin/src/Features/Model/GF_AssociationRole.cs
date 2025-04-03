
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 18:54, @gisvlasta.
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
  public class GF_AssociationRole : GF_PropertyType {

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

    //private PF_PortrayalRule[] rulefield;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("rule")]
    //public PF_PortrayalRule[] rule {
    //  get {
    //    return rulefield;
    //  }
    //  set {
    //    rulefield = value;
    //  }
    //}

  }

}
