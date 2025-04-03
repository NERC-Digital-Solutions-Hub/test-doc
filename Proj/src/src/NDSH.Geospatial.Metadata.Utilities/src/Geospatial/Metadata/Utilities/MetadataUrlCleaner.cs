using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.Metadata.Utilities {
  public class MetadataUrlCleaner {

    /* 
     * [x]1. Find all BGS service from metadata
     * [x]2. find all srv:operatesOn to find how many 'datasets' are used by the service
     * [x]3. find the MD_DigitalTransferOptions of the service and check its CI_OnlineResource
     * [x]4. Check if the service is a WMS !!! it may be not a WMS 
     * [x]5. Use its GetCapabilities URL to get the capabilities document
     * [x]6. Parse the capabilities document - It should have a root Layer which will have children layers
     * [x]7. Check each of the children layers and find out their  MetadataURL.OnlineResource.xlink
     * this has the URL to the dataset metadata document associated with the Layer
     * it should be possible to get this url and extract from the URL the fileidentifier of the dataset metadata
     * once you get the fileIdentifier then you have managed to associate a dataset with a particular Layer of a Service
    */

  }
}
