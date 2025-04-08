
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 01:57, @gisvlasta.
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
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Multiplicity_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Multiplicity_PropertyType")]
  public class Multiplicity_PropertyType : ObjectReference_PropertyType
  {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Multiplicity_PropertyType"/>.
    /// </summary>
    public Multiplicity_PropertyType()
    {
      _multiplicity = new Multiplicity_Type();
    }

    #endregion

    #region Public Properties

    private Multiplicity_Type _multiplicity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Multiplicity", Order = 0)]
    [JsonProperty("Multiplicity", Order = 0)]
    public Multiplicity_Type Multiplicity
    {
      get
      {
        return _multiplicity;
      }
      set
      {
        if (_multiplicity == value)
        {
          return;
        }
        if (_multiplicity == null || _multiplicity.Equals(value) != true)
        {
          _multiplicity = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
