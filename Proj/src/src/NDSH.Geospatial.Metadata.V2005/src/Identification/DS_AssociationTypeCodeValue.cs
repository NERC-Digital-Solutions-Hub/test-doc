
#region Header
// Title Name        : DS_AssociationTypeCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The justification for the correlation of two datasets.
// Created by        : 19/09/2022, 17:36, @gisvlasta
// Updated by        : 18/12/2022, 00:33, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// The justification for the correlation of two datasets.
  /// </summary>
  [Serializable]
  public enum DS_AssociationTypeCodeValue {

    /// <summary>
    /// Reference from one dataset to another.
    /// </summary>
    [XmlEnum(Name = "crossReference")]
    [EnumMember(Value = "crossReference")]
    CrossReference = 1,

    /// <summary>
    /// Reference to a master dataset of which this one is a part.
    /// </summary>
    [XmlEnum(Name = "largerWorkeCitation")]
    [EnumMember(Value = "largerWorkeCitation")]
    LargerWorkeCitation = 2,

    /// <summary>
    /// Part of same structured set of data held in a computer.
    /// </summary>
    [XmlEnum(Name = "partOfSeamlessDatabase")]
    [EnumMember(Value = "partOfSeamlessDatabase")]
    PartOfSeamlessDatabase = 3,

    /// <summary>
    /// Mapping and charting information from which the dataset content originates.
    /// </summary>
    [XmlEnum(Name = "source")]
    [EnumMember(Value = "source")]
    Source = 4,

    /// <summary>
    /// Part of a set of imagery that when used together, provides three-dimensional images.
    /// </summary>
    [XmlEnum(Name = "stereoMate")]
    [EnumMember(Value = "stereoMate")]
    StereoMate = 5,

  }

}
