
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.ReferenceSystems {

  [XmlInclude(typeof(ML_ImageCRS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ImageCRSType")]
  public class ImageCRSType : AbstractCRSType {

    #region Private fields
    private object _item;
    private ImageDatumPropertyType _imageDatum;
    #endregion

    /// <summary>
    /// ImageCRSType class constructor
    /// </summary>
    public ImageCRSType() {
      _imageDatum = new ImageDatumPropertyType();
    }

    [XmlElement("affineCS", typeof(AffineCSPropertyType), Order = 0)]
    [XmlElement("cartesianCS", typeof(CartesianCSPropertyType), Order = 0)]
    [XmlElement("usesObliqueCartesianCS", typeof(ObliqueCartesianCSPropertyType), Order = 0)]
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
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("imageDatum", Order = 1)]
    public ImageDatumPropertyType ImageDatum {
      get {
        return _imageDatum;
      }
      set {
        if (_imageDatum == value) {
          return;
        }
        if (_imageDatum == null || _imageDatum.Equals(value) != true) {
          _imageDatum = value;
          OnPropertyChanged("ImageDatum");
        }
      }
    }

  }

}
