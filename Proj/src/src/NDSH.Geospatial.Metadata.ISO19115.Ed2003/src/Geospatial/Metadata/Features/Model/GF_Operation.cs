
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

  [Serializable()]
  //[XmlType(AnonymousType = false)]
  //[XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_Operation : GF_PropertyType {

    // TODO: GF - Model / [Xml / [Json / Property Logic

    #region Public Properties

    private CharacterString _signature;

    public CharacterString Signature {
      get => _signature;
      // TODO: SetProperty
      set {
        _signature = value;
      }
    }

    private List<GF_AttributeType> _observesValuesOf;

    public List<GF_AttributeType> ObservesValuesOf {
      get => _observesValuesOf;
      // TODO: SetProperty
      set {
        _observesValuesOf = value;
      }
    }

    private List<GF_AttributeType> _triggeredByValuesOf;

    public List<GF_AttributeType> TriggeredByValuesOf {
      get => _triggeredByValuesOf;
      // TODO: SetProperty
      set {
        _triggeredByValuesOf = value;
      }
    }

    private List<GF_AttributeType> _affectsValuesOf;

    public List<GF_AttributeType> AffectsValuesOf {
      get => _affectsValuesOf;
      // TODO: SetProperty
      set {
        _affectsValuesOf = value;
      }
    }

    private List<GF_AssociationType> _dependsOn;

    public List<GF_AssociationType> DependsOn {
      get => _dependsOn;
      // TODO: SetProperty
      set {
        _dependsOn = value;
      }
    }

    #endregion

  }

}
