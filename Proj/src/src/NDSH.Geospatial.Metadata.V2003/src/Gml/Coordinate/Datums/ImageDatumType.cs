
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.Datums;
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums {

  [XmlInclude(typeof(ML_ImageDatum_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ImageDatumType")]
  public class ImageDatumType : AbstractDatumType {

    #region Private fields
    private CodeWithAuthorityType _pixelInCell;
    #endregion

    /// <summary>
    /// ImageDatumType class constructor
    /// </summary>
    public ImageDatumType() {
      _pixelInCell = new CodeWithAuthorityType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("pixelInCell", Order = 0)]
    public CodeWithAuthorityType PixelInCell {
      get {
        return _pixelInCell;
      }
      set {
        if (_pixelInCell == value) {
          return;
        }
        if (_pixelInCell == null || _pixelInCell.Equals(value) != true) {
          _pixelInCell = value;
          OnPropertyChanged("PixelInCell");
        }
      }
    }
  }

}
