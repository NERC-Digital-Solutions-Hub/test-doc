
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoComplexType")]
  public class TopoComplexType : AbstractTopologyType {
    #region Private fields
    private TopoComplexMemberType _maximalComplex;
    private List<TopoComplexMemberType> _superComplex;
    private List<TopoComplexMemberType> _subComplex;
    private List<TopoPrimitiveMemberType> _topoPrimitiveMember;
    private TopoPrimitiveArrayAssociationType _topoPrimitiveMembers;
    private bool _isMaximal;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoComplexType class constructor
    /// </summary>
    public TopoComplexType() {
      _topoPrimitiveMembers = new TopoPrimitiveArrayAssociationType();
      _topoPrimitiveMember = new List<TopoPrimitiveMemberType>();
      _subComplex = new List<TopoComplexMemberType>();
      _superComplex = new List<TopoComplexMemberType>();
      _maximalComplex = new TopoComplexMemberType();
      _isMaximal = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("maximalComplex", Order = 0)]
    public TopoComplexMemberType maximalComplex {
      get {
        return _maximalComplex;
      }
      set {
        if (_maximalComplex == value) {
          return;
        }
        if (_maximalComplex == null || _maximalComplex.Equals(value) != true) {
          _maximalComplex = value;
          OnPropertyChanged("maximalComplex");
        }
      }
    }

    [XmlElement("superComplex", Order = 1)]
    [JsonProperty("superComplex", Order = 1)]
    public List<TopoComplexMemberType> superComplex {
      get {
        return _superComplex;
      }
      set {
        if (_superComplex == value) {
          return;
        }
        if (_superComplex == null || _superComplex.Equals(value) != true) {
          _superComplex = value;
          OnPropertyChanged("superComplex");
        }
      }
    }

    [XmlElement("subComplex", Order = 2)]
    [JsonProperty("subComplex", Order = 2)]
    public List<TopoComplexMemberType> subComplex {
      get {
        return _subComplex;
      }
      set {
        if (_subComplex == value) {
          return;
        }
        if (_subComplex == null || _subComplex.Equals(value) != true) {
          _subComplex = value;
          OnPropertyChanged("subComplex");
        }
      }
    }

    [XmlElement("topoPrimitiveMember", Order = 3)]
    [JsonProperty("topoPrimitiveMember", Order = 3)]
    public List<TopoPrimitiveMemberType> topoPrimitiveMember {
      get {
        return _topoPrimitiveMember;
      }
      set {
        if (_topoPrimitiveMember == value) {
          return;
        }
        if (_topoPrimitiveMember == null || _topoPrimitiveMember.Equals(value) != true) {
          _topoPrimitiveMember = value;
          OnPropertyChanged("topoPrimitiveMember");
        }
      }
    }

    [XmlElement(Order = 4)]
    [JsonProperty("topoPrimitiveMembers", Order = 4)]
    public TopoPrimitiveArrayAssociationType topoPrimitiveMembers {
      get {
        return _topoPrimitiveMembers;
      }
      set {
        if (_topoPrimitiveMembers == value) {
          return;
        }
        if (_topoPrimitiveMembers == null || _topoPrimitiveMembers.Equals(value) != true) {
          _topoPrimitiveMembers = value;
          OnPropertyChanged("topoPrimitiveMembers");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("isMaximal")]
    public bool isMaximal {
      get {
        return _isMaximal;
      }
      set {
        if (_isMaximal.Equals(value) != true) {
          _isMaximal = value;
          OnPropertyChanged("isMaximal");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType aggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }
}