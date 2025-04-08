
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : 
// ---------------------------------------------------------------------------------------------------------------------
// 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Multiplicities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  [Serializable()]
  //[XmlType(AnonymousType = false)]
  //[XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_AssociationRole : GF_PropertyType {

    #region Public Properties

    private TypeName_Type _valueType;

    public TypeName_Type ValueType {
      get => _valueType;
      set {
        _valueType = value;
      }
    }

    private Multiplicity_Type _cardinality;

    public Multiplicity_Type Cardinality {
      get => _cardinality;
      set {
        _cardinality = value;
      }
    }

    #endregion

    //private GF_Constraint[] constrainedByField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("constrainedBy")]
    //public GF_Constraint[] constrainedBy {
    //  get {
    //    return constrainedByField;
    //  }
    //  set {
    //    constrainedByField = value;
    //  }
    //}

    //private PF_PortrayalRule[] rulefield;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("rule")]
    //public PF_PortrayalRule[] rule {
    //  get {
    //    return rulefield;
    //  }
    //  set {
    //    rulefield = value;
    //  }
    //}

  }

}
