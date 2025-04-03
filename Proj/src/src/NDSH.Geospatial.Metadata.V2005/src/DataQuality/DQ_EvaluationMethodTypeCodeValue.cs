
#region Header
// Title Name        : DQ_EvaluationMethodTypeCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The type of method for evaluating an identified data quality measure.
// Created by        : 19/09/2022, 17:33, @gisvlasta
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
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

namespace NDSH.Geospatial.Metadata.V2005.DataQuality {

  /// <summary>
  /// The type of method for evaluating an identified data quality measure.
  /// </summary>
  [Serializable]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public enum DQ_EvaluationMethodTypeCodeValue {

    /// <summary>
    /// Method of evaluating the quality of a dataset based on inspection of items within
    /// the dataset, where all data required is internal to the dataset being evaluated.
    /// </summary>
    [XmlEnum(Name = "directInternal")]
    [EnumMember(Value = "directInternal")]
    DirectInternal = 1,

    /// <summary>
    /// Method of evaluating the quality of a dataset based on inspection of items within
    /// the dataset, where reference data external to the dataset being evaluated is required.
    /// </summary>
    [XmlEnum(Name = "directExternal")]
    [EnumMember(Value = "directExternal")]
    DirectExternal = 2,

    /// <summary>
    /// Method of evaluating the quality of a dataset based on external knowledge.
    /// </summary>
    [XmlEnum(Name = "indirect")]
    [EnumMember(Value = "indirect")]
    Indirect = 3,

  }

}
