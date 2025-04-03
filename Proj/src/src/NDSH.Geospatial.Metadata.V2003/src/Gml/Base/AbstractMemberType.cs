
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 09:24, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Dictionary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.GmlBase {

  /// <summary>
  /// To create a collection of GML Objects that are not all features, a property type shall
  /// be derived by extension from gml:AbstractMemberType. This abstract property type is intended
  /// to be used only in object types where software shall be able to identify that an instance of
  /// such an object type is to be interpreted as a collection of objects. By default,
  /// this abstract property type does not imply any ownership of the objects in the collection.
  /// The owns attribute of gml:OwnershipAttributeGroup may be used on a property element instance
  /// to assert ownership of an object in the collection. A collection shall not own an object
  /// already owned by another object.
  /// </summary>
  [XmlInclude(typeof(DictionaryEntryType))]
  [Serializable]
  [XmlType("AbstractMemberType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractMemberType")]
  public abstract class AbstractMemberType : ObservableModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMemberType"/>.
    /// </summary>
    public AbstractMemberType() {
      _owns = false;
    }

    #endregion

    #region Private Properties

    private bool _owns;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
