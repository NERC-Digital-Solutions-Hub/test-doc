
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums
{

  [XmlInclude(typeof(ML_ImageDatum_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ImageDatumType")]
  public class ImageDatumType : AbstractDatumType
  {
    #region Private fields
    private CodeWithAuthorityType _pixelInCell;
    #endregion

    /// <summary>
    /// ImageDatumType class constructor
    /// </summary>
    public ImageDatumType()
    {
      _pixelInCell = new CodeWithAuthorityType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("pixelInCell", Order = 0)]
    public CodeWithAuthorityType pixelInCell
    {
      get
      {
        return _pixelInCell;
      }
      set
      {
        if (_pixelInCell == value)
        {
          return;
        }
        if (_pixelInCell == null || _pixelInCell.Equals(value) != true)
        {
          _pixelInCell = value;
          OnPropertyChanged("pixelInCell");
        }
      }
    }
  }
}