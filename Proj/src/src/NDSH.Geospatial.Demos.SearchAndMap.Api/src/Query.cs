using NDSH.Geospatial.Metadata.Utilities.DatabaseContext;
using NDSH.Geospatial.Metadata.Utilities.Models;
using Serilog;

public class Query {

  public BgsLayer GetBgsLayer() { // for testing only.
    return new BgsLayer { ArcGisLayerName = "ok" };
  }
  
  [UseFiltering]
  public IQueryable<BgsLayer> GetBgsLayers(MetadataContextGraphApi dbContext) {
    if (dbContext == null) {
      Log.Logger.Error("!!!");
    }
    return dbContext?.BgsLayers;
  }

}