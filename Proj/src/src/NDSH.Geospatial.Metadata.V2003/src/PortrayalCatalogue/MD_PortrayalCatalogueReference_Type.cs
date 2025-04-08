
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 17:28, @gisvlasta.
// Updated by        : 09/01/2023, 20:40, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.PortrayalCatalogue {

  /// <summary>
  /// Information identifing the portrayal catalogue used.
  /// </summary>
  [Serializable]
  [XmlType("MD_PortrayalCatalogueReference", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_PortrayalCatalogueReference", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_PortrayalCatalogueReference")]
  public class MD_PortrayalCatalogueReference_Type : AbstractObject_Type {

    #region Constructors - Destructors

    private List<CI_Citation_PropertyType> _portrayalCatalogueCitation;

    /// <summary>
    /// Initializes the <see cref="MD_PortrayalCatalogueReference_Type"/>.
    /// </summary>
    public MD_PortrayalCatalogueReference_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _portrayalCatalogueCitation  = default; //  new List<CI_Citation_PropertyType>();

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

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("portrayalCatalogueCitation", Order = 0)]
    [JsonProperty("portrayalCatalogueCitation", Order = 0)]
    public List<CI_Citation_PropertyType> PortrayalCatalogueCitation {
      get {
        return _portrayalCatalogueCitation;
      }
      set {
        if (_portrayalCatalogueCitation == value) {
          return;
        }
        if (_portrayalCatalogueCitation == null || _portrayalCatalogueCitation.Equals(value) != true) {
          _portrayalCatalogueCitation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
