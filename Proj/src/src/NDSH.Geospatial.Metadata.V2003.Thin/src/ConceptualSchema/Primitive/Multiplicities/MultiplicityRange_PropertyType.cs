
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 02:09, @gisvlasta.
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
  [XmlType("MultiplicityRange_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("MultiplicityRange_PropertyType")]
  public class MultiplicityRange_PropertyType : ObjectReference_PropertyType
  {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MultiplicityRange_PropertyType"/>.
    /// </summary>
    public MultiplicityRange_PropertyType()
    {
      _multiplicityRange = new MultiplicityRange_Type();
    }

    #endregion

    #region Public Properties

    private MultiplicityRange_Type _multiplicityRange;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MultiplicityRange", Order = 0)]
    [JsonProperty("MultiplicityRange", Order = 0)]
    public MultiplicityRange_Type MultiplicityRange
    {
      get
      {
        return _multiplicityRange;
      }
      set
      {
        if (_multiplicityRange == value)
        {
          return;
        }
        if (_multiplicityRange == null || _multiplicityRange.Equals(value) != true)
        {
          _multiplicityRange = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
