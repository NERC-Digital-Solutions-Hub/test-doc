
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 05/03/2025, @gisvlasta - Polished class.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : This class is documented in full in ISO 19109.
// ---------------------------------------------------------------------------------------------------------------------
// Advised that the following are properties of the GF_FeatureType
// --------
// - name:       A CharacterString representing the name of the feature type.
// - definition: A CharacterString providing a clear description of the feature type.
// - isAbstract: A Boolean indicating whether the feature type is abstract.
// - properties: A collection of GF_PropertyType instances defining the attributes and associations of the feature type.
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic
  // WARNING: Compare properties with the advisable ones.

  /// <summary>
  /// Textual information describing the concept of a feature type, containing all feature types.
  /// </summary>
  [Serializable()]
  //[XmlType(AnonymousType = false)]
  //[XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_FeatureType : ObservableDbEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_FeatureType"/>.
    /// </summary>
    public GF_FeatureType() {
      _typeName = default;
      _definition = default;
      _isAbstract = default;
      _constrainedBy = default;
      _linkBetween = default;
      _carrierOfCharacteristics = default;
    }

    #endregion


    #region Public Properties

    // WARNING: Check which properties need to be nullable.

    private LocalName _typeName;

    //[XmlElement("typeName", Order = 0)]
    [JsonProperty("typeName", Order = 0)]
    public LocalName TypeName {
      get => _typeName;
      set => SetProperty(ref _typeName, value);
    }

    private CharacterString _definition;

    //[XmlElement("definition", Order = 1)]
    [JsonProperty("definition", Order = 1)]
    public CharacterString Definition {
      get => _definition;
      set => SetProperty(ref _definition, value);
    }

    private bool _isAbstract;

    //[XmlElement("isAbstract", Order = 2)]
    [JsonProperty("isAbstract", Order = 2)]
    public bool IsAbstract {
      get => _isAbstract;
      set => SetProperty(ref _isAbstract, value);
    }

    private ObservableCollection<GF_Constraint> _constrainedBy;

    //[XmlElement("constrainedBy", Order = 3)]
    [JsonProperty("constrainedBy", Order = 3)]
    public ObservableCollection<GF_Constraint> ConstrainedBy {
      get => _constrainedBy;
      set => SetProperty(ref _constrainedBy, value);
    }

    private ObservableCollection<GF_AssociationType> _linkBetween;

    //[XmlElement("linkBetween", Order = 4)]
    [JsonProperty("linkBetween", Order = 4)]
    public ObservableCollection<GF_AssociationType> LinkBetween {
      get => _linkBetween;
      set => SetProperty(ref _linkBetween, value);
    }

    private ObservableCollection<GF_PropertyType> _carrierOfCharacteristics;

    //[XmlElement("carrierOfCharacteristics", Order = 5)]
    [JsonProperty("carrierOfCharacteristics", Order = 5)]
    public ObservableCollection<GF_PropertyType> CarrierOfCharacteristics {
      get => _carrierOfCharacteristics;
      set => SetProperty(ref _carrierOfCharacteristics, value);
    }

    #endregion

    //private MD_Metadata featureTypeMetadataField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("featureTypeMetadata")]
    //public MD_Metadata featureTypeMetadata {
    //  get {
    //    return featureTypeMetadataField;
    //  }
    //  set {
    //    featureTypeMetadataField = value;
    //  }
    //}

    //private PF_FeaturePortrayal[] ruleSetField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("ruleSet")]
    //public PF_FeaturePortrayal[] ruleSet {
    //  get {
    //    return ruleSetField;
    //  }
    //  set {
    //    ruleSetField = value;
    //  }
    //}

  }

}
