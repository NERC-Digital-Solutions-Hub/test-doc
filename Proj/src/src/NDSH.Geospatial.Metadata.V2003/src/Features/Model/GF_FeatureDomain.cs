
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 17:04, @fdq09eca.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Application;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(AnonymousType = false)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_FeatureDomain {

    private GF_Feature_PropertyType _featureType;

    /// <summary>
    /// 
    /// </summary>
    public GF_Feature_PropertyType FeatureType {
      get {
        return _featureType;
      }
      set {
        _featureType = value;
      }
    }

    private List<GF_Feature_PropertyType> _setOfTypes;

    /// <summary>
    /// 
    /// </summary>
    public List<GF_Feature_PropertyType> SetOfTypes {
      get {
        return _setOfTypes;
      }
      set {
        _setOfTypes = value;
      }
    }

    private GenericName_PropertyType _feature;

    /// <summary>
    /// 
    /// </summary>
    public GenericName_PropertyType Feature {
      get {
        return _feature;
      }
      set {
        _feature = value;
      }
    }

    private DS_DataSet_PropertyType _setOfFeature;

    /// <summary>
    /// 
    /// </summary>
    public DS_DataSet_PropertyType SetOfFeature {
      get {
        return _setOfFeature;
      }
      set {
        _setOfFeature = value;
      }
    }

  }

}
