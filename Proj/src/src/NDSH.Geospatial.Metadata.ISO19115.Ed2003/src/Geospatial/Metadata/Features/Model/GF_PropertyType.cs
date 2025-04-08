
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
// Advised that the following are properties of the GF_PropertyType
// --------
// - name:        A CharacterString representing the name of the property.
// - type:        A reference to the data type of the property.
// - cardinality: Specifies the allowed number of occurrences for the property.
// - definition:  A CharacterString providing a clear description of the property's meaning.
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
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic
  // WARNING: Compare properties with the advisable ones.

  /// <summary>
  /// Textual information related to the feature type because its text comprises characteristics and
  /// behaviour of any property of a feature type, as well as its roles within associations between features.
  /// </summary>
  [Serializable()]
  //[XmlType(AnonymousType = false)]
  //[XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_PropertyType : ObservableDbEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_PropertyType"/>.
    /// </summary>
    public GF_PropertyType() {
      _memberName = default;
      _definition = default;
      _constrainedBy = default;
    }

    #endregion

    #region Public Properties

    // WARNING: Check which properties need to be nullable.

    private LocalName _memberName;

    /// <summary>
    /// Gets/Sets the name of the property.
    /// </summary>
    //[XmlElement("memberName")]
    [JsonProperty("memberName", Order = 0)]
    public LocalName MemberName {
      get => _memberName;
      set => SetProperty(ref _memberName, value);
    }

    private CharacterString _definition;

    /// <summary>
    /// Gets/Sets a clear description of the property's meaning.
    /// </summary>
    //[XmlElement("definition")]
    [JsonProperty("definition", Order = 1)]
    public CharacterString Definition {
      get => _definition;
      set => _definition = value;
    }

    private ObservableCollection<GF_Constraint> _constrainedBy;

    //[XmlElement("constrainedBy")]
    [JsonProperty("constrainedBy", Order = 2)]
    public ObservableCollection<GF_Constraint> ConstrainedBy {
      get => _constrainedBy;
      set => _constrainedBy = value;
    }

    // WARNING - What about the following properties ?

    //public Type DataType {
    //  get; set;
    //}

    //public (int Min, int Max) Cardinality {
    //  get; set;
    //}

    #endregion

    // WARNING - Decide if these properties can be used in the Metadata or elsewhere

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
