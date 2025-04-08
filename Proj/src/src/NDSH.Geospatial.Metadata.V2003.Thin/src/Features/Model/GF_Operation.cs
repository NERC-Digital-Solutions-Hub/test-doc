
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 19:56, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Features.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable()]
  [XmlType(AnonymousType = false)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_Operation : GF_PropertyType {

    // TODO: GF - Model / [Xml / [Json / Property Logic

    #region Public Properties

    private CharacterString _signature;

    /// <summary>
    /// 
    /// </summary>
    public CharacterString Signature {
      get {
        return _signature;
      }
      set {
        _signature = value;
      }
    }

    private List<GF_Attribute_PropertyType> _observesValuesOf;

    /// <summary>
    /// 
    /// </summary>
    public List<GF_Attribute_PropertyType> ObservesValuesOf {
      get {
        return _observesValuesOf;
      }
      set {
        _observesValuesOf = value;
      }
    }

    private List<GF_Attribute_PropertyType> _triggeredByValuesOf;

    /// <summary>
    /// 
    /// </summary>
    public List<GF_Attribute_PropertyType> TriggeredByValuesOf {
      get {
        return _triggeredByValuesOf;
      }
      set {
        _triggeredByValuesOf = value;
      }
    }

    private List<GF_Attribute_PropertyType> _affectsValuesOf;

    /// <summary>
    /// 
    /// </summary>
    public List<GF_Attribute_PropertyType> AffectsValuesOf {
      get {
        return _affectsValuesOf;
      }
      set {
        _affectsValuesOf = value;
      }
    }

    private List<GF_Association_PropertyType> _dependsOn;

    /// <summary>
    /// 
    /// </summary>
    public List<GF_Association_PropertyType> DependsOn {
      get {
        return _dependsOn;
      }
      set {
        _dependsOn = value;
      }
    }

    #endregion

  }

}
