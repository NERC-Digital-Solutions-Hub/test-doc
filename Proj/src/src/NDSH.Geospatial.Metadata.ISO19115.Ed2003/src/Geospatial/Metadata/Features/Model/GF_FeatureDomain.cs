
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : 
// ---------------------------------------------------------------------------------------------------------------------
//
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Metadata.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  [Serializable]
  //[XmlType(AnonymousType = false)]
  //[XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_FeatureDomain {

    private GF_FeatureType _featureType;

    public GF_FeatureType FeatureType {
      get => _featureType;
      // TODO: SetProperty
      set {
        _featureType = value;
      }
    }

    private List<GF_FeatureType> _setOfTypes;

    public List<GF_FeatureType> SetOfTypes {
      get => _setOfTypes;
      // TODO: SetProperty
      set {
        _setOfTypes = value;
      }
    }

    private GenericName _feature;

    public GenericName Feature {
      get => _feature;
      // TODO: SetProperty
      set {
        _feature = value;
      }
    }

    private DS_DataSet_Type _setOfFeature;

    public DS_DataSet_Type SetOfFeature {
      get => _setOfFeature;
      // TODO: SetProperty
      set {
        _setOfFeature = value;
      }
    }

  }

}
