
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005 {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("Entity", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("Entity", Namespace = "http://www.isotc211.org/2005/gmd")]
  public class Entity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Entity"/>.
    /// </summary>
    public Entity() {
      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");
      xmlns.Add("gco", "http://www.isotc211.org/2005/gco");
      xmlns.Add("gml", "http://www.opengis.net/gml/3.2");
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");
      xmlns.Add("gsr", "http://www.isotc211.org/2005/gsr");
      xmlns.Add("gss", "http://www.isotc211.org/2005/gss");
      xmlns.Add("gts", "http://www.isotc211.org/2005/gts");
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");
      xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
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

    private object _item;

    /// <summary>
    /// 
    /// </summary>
    //[XmlElement(Order = 0, ElementName = "value")]
    //[XmlElement("CharacterString", typeof(Examples.CharacterString), Namespace = "http://www.isotc211.org/2005/gco")]
    [XmlElement("CI_Address", typeof(CI_Address), Namespace = "http://www.isotc211.org/2005/gmd")]
    [XmlElement("CI_Telephone", typeof(CI_Telephone), Namespace = "http://www.isotc211.org/2005/gmd")]
    [XmlElement("CI_ResponsibleParty", typeof(CI_ResponsibleParty), Namespace = "http://www.isotc211.org/2005/gmd")]
    [XmlElement("CharacterString", typeof(CharacterString), Namespace = "http://www.isotc211.org/2005/gco")]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
        }
      }
    }

    #endregion

  }

}
