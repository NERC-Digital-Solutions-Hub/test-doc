
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 01:42, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Multiplicities {

  /// <summary>
  /// Use to represent the possible cardinality of a relation.
  /// Represented by a set of simple multiplicity ranges.
  /// </summary>
  [Serializable]
  [XmlType("Multiplicity", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot
  [JsonObject("Multiplicity")]
  public class Multiplicity_Type : AbstractObject_Type
  {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Multiplicity_Type"/>.
    /// </summary>
    public Multiplicity_Type()
    {
      _range = new List<MultiplicityRange_PropertyType>();
    }

    #endregion

    #region Public Properties

    private List<MultiplicityRange_PropertyType> _range;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("range", Order = 0)]
    [JsonProperty("range", Order = 0)]
    public List<MultiplicityRange_PropertyType> Range
    {
      get
      {
        return _range;
      }
      set
      {
        if (_range == value)
        {
          return;
        }
        if (_range == null || _range.Equals(value) != true)
        {
          _range = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
