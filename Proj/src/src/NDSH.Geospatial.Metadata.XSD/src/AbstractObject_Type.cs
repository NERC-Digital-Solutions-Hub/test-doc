
#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata {

  // TODO: Make OnPropertyChanged modern.

  /// <summary>
  /// 
  /// </summary>
  //
  // TODO: Important - Uncomment XmlIncludes in AbstractObject_Type
  //
  //[XmlInclude(typeof(URI_Type))]
  //[XmlInclude(typeof(MD_ScopeDescription_Type))]
  //[XmlInclude(typeof(MD_Scope_Type))]
  //[XmlInclude(typeof(Abstract_Parameter_Type))]
  //[XmlInclude(typeof(Abstract_StandardOrderProcess_Type))]
  //[XmlInclude(typeof(Abstract_SpatialResolution_Type))]
  //[XmlInclude(typeof(Abstract_Platform_Type))]
  //[XmlInclude(typeof(Abstract_PortrayalCatalogueInformation_Type))]
  //[XmlInclude(typeof(Abstract_ResourceDescription_Type))]
  //[XmlInclude(typeof(Abstract_MetadataExtension_Type))]
  //[XmlInclude(typeof(Abstract_ReferenceSystem_Type))]
  //[XmlInclude(typeof(Abstract_SpatialRepresentation_Type))]
  [XmlInclude(typeof(Abstract_Metadata_Type))]
  [XmlInclude(typeof(MD_Metadata_Type))]
  //[XmlInclude(typeof(Abstract_MaintenanceInformation_Type))]
  //[XmlInclude(typeof(Abstract_LineageInformation_Type))]
  //[XmlInclude(typeof(Abstract_Format_Type))]
  //[XmlInclude(typeof(Abstract_Distribution_Type))]
  //[XmlInclude(typeof(Abstract_ContentInformation_Type))]
  //[XmlInclude(typeof(Abstract_ApplicationSchemaInformation_Type))]
  //[XmlInclude(typeof(Abstract_AcquisitionInformation_Type))]
  //[XmlInclude(typeof(Abstract_Constraints_Type))]
  //[XmlInclude(typeof(MD_BrowseGraphic_Type))]
  //[XmlInclude(typeof(CI_Series_Type))]
  //[XmlInclude(typeof(Abstract_Citation_Type))]
  //[XmlInclude(typeof(CI_Citation_Type))]
  //[XmlInclude(typeof(MD_Identifier_Type))]
  //[XmlInclude(typeof(Abstract_OnlineResource_Type))]
  //[XmlInclude(typeof(CI_OnlineResource_Type))]
  //[XmlInclude(typeof(CI_Address_Type))]
  //[XmlInclude(typeof(CI_Telephone_Type))]
  //[XmlInclude(typeof(CI_Contact_Type))]
  //[XmlInclude(typeof(AbstractCI_Party_Type))]
  //[XmlInclude(typeof(CI_Organisation_Type))]
  //[XmlInclude(typeof(CI_Individual_Type))]
  //[XmlInclude(typeof(Abstract_Extent_Type))]
  //[XmlInclude(typeof(Abstract_Responsibility_Type))]
  //[XmlInclude(typeof(CI_Responsibility_Type))]
  //[XmlInclude(typeof(Abstract_TypedDate_Type))]
  //[XmlInclude(typeof(CI_Date_Type))]
  //[XmlInclude(typeof(PT_Locale_Type))]
  //[XmlInclude(typeof(PT_LocaleContainer_Type))]
  //[XmlInclude(typeof(Abstract_QualityElement_Type))]
  //[XmlInclude(typeof(Abstract_DataQuality_Type))]
  //[XmlInclude(typeof(MultiplicityRange_Type))]
  //[XmlInclude(typeof(Multiplicity_Type))]
  //[XmlInclude(typeof(MemberName_Type))]
  //[XmlInclude(typeof(TypeName_Type))]
  //[XmlInclude(typeof(PT_FreeText_Type))]
  //[XmlInclude(typeof(MD_MetadataScope_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "http://standards.iso.org/iso/19115/-3/gco/1.0")]
  [XmlRootAttribute("AbstractObject_Type")]
  [JsonObject("AbstractObject_Type")]
  public abstract class AbstractObject_Type : EntityBase<AbstractObject_Type> {

    #region Public Properties

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged("Id");
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged("Uuid");
        }
      }
    }

    #endregion

  }

}
