
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:34, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          :
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// Range of date validity.
  /// </summary>
  /// <remarks>ShortName: ReqstDate</remarks>
  [XmlType("MI_RequestedDate", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_RequestedDate", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_RequestedDate")]
  public class MI_RequestedDate_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_RequestedDate_Type"/>.
    /// </summary>
    public MI_RequestedDate_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _requestedDateOfCollection = default; // new DateTime_PropertyType();
      _latestAcceptableDate = default; // new DateTime_PropertyType();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties
    
    private DateTime_PropertyType _requestedDateOfCollection;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("requestedDateOfCollection", Order = 0)]
    [JsonProperty("requestedDateOfCollection", Order = 0)]
    public DateTime_PropertyType RequestedDateOfCollection {
      get {
        return _requestedDateOfCollection;
      }
      set {
        if (_requestedDateOfCollection == value) {
          return;
        }
        if (_requestedDateOfCollection == null || _requestedDateOfCollection.Equals(value) != true) {
          _requestedDateOfCollection = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime_PropertyType _latestAcceptableDate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("latestAcceptableDate", Order = 1)]
    [JsonProperty("latestAcceptableDate", Order = 1)]
    public DateTime_PropertyType LatestAcceptableDate {
      get {
        return _latestAcceptableDate;
      }
      set {
        if (_latestAcceptableDate == value) {
          return;
        }
        if (_latestAcceptableDate == null || _latestAcceptableDate.Equals(value) != true) {
          _latestAcceptableDate = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
