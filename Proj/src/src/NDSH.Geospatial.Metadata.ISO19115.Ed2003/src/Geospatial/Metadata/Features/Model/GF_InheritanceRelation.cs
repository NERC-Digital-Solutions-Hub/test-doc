
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
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

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  [Serializable()]
  //[XmlType(AnonymousType = false)]
  //[XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_InheritanceRelation {

    // WARNING: Check which value types need to be nullable.

    #region Public Properties

    private CharacterString _name;

    public CharacterString Name {
      get => _name;
      // TODO: SetProperty
      set {
        _name = value;
      }
    }

    private CharacterString _description;

    public CharacterString Description {
      get => _description;
      // TODO: SetProperty
      set {
        _description = value;
      }
    }

    private bool _uniqueIsntance;

    public bool UniqueInstance { // TODO: Should we use Boolean_PropertyType or an other simpler type???
      get => _uniqueIsntance;
      // TODO: SetProperty
      set {
        _uniqueIsntance = value;
      }
    }

    private GF_FeatureType _subtype;

    public GF_FeatureType Subtype {
      get => _subtype;
      // TODO: SetProperty
      set {
        _subtype = value;
      }
    }

    private GF_FeatureType _supertype;

    public GF_FeatureType Supertype {
      get => _supertype;
      // TODO: SetProperty
      set {
        _supertype = value;
      }
    }

    #endregion

  }

}
