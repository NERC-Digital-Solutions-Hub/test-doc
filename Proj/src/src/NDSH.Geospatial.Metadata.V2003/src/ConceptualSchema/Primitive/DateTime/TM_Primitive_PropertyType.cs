
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime {

  [Serializable]
  [XmlType("TM_Primitive_PropertyType", Namespace = "http://www.isotc211.org/2005/gts")]
  [JsonObject("TM_Primitive_PropertyType")]
  public class TM_Primitive_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractTimePrimitiveType _abstractTimePrimitive;

    [XmlElement("AbstractTimePrimitive", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractTimePrimitive", Order = 0)]
    public AbstractTimePrimitiveType AbstractTimePrimitive {
      get => _abstractTimePrimitive;
      set {
        if (_abstractTimePrimitive == value) {
          return;
        }
        if (_abstractTimePrimitive == null || !_abstractTimePrimitive.Equals(value)) {
          _abstractTimePrimitive = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
