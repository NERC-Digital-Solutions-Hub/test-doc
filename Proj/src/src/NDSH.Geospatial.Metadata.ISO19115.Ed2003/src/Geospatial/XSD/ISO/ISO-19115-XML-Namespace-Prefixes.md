
## **📌 ISO 19115 XML Namespace Prefixes**
| **Prefix** | **Stands for** | **Purpose / Description** | **ISO Standard** |
|------------|---------------|---------------------------|------------------|
| **`gco`** | **Geographic Common** | Defines **primitive types** like `CharacterString`, `Integer`, `Boolean`, `Date`, etc. | ISO 19103 (Conceptual Schema Language) |
| **`gfc`** | **Geographic Feature Catalogue** | Defines **feature catalogues**, including feature types, attributes, and associations. | ISO 19110 (Feature Catalog) |
| **`gmd`** | **Geographic Metadata** | Defines **metadata elements** like `MD_Metadata`, `MD_Identification`, `MD_Distribution`, etc. | ISO 19115-1 (Core Metadata) |
| **`gmi`** | **Metadata for Imagery** | Extends `gmd` with metadata for **remote sensing** and **imagery** (e.g., `MI_Metadata`). | ISO 19115-2 (Imagery Metadata) |
| **`gml`** | **Geography Markup Language** | Defines **spatial geometries**, coordinate reference systems, and topology. | ISO 19136 (GML) |
| **`gmx`** | **Metadata Extension** | Provides **metadata extensions**, including codelists, datatypes, and schema elements. | ISO 19115-1 (Extended Metadata) |
| **`gplr`** | **Geographic Polar Data** | Handles **polar-specific metadata** for datasets related to the **Arctic and Antarctic regions**. | ISO 19115 (Polar Data Extension) |
| **`grg`** | **Geographic Reference Grid** | Defines **gridded data structures**, including grid-based spatial reference systems. | ISO 19123 (Coverage Geometry and Functions) |
| **`gsr`** | **Geospatial Spatial Reference** | Defines **spatial referencing systems**, including coordinate reference systems (CRS). | ISO 19111 (Spatial Referencing by Coordinates) |
| **`gss`** | **Geospatial Spatial Schema** | Specifies **spatial schema elements** such as `GM_Point`, `GM_Surface`, `GM_Curve`, etc. | ISO 19107 (Spatial Schema) |
| **`gts`** | **Geospatial Temporal Schema** | Defines **temporal schema elements**, including time periods, temporal extents, and calendars. | ISO 19108 (Temporal Schema) |
| **`srv`** | **Geospatial Services** | Defines **service metadata**, including `SV_ServiceIdentification` and `SV_OperationMetadata`. | ISO 19119 (Geographic Information Services) |

---

## **📌 Example XML Using Multiple Prefixes**
```xml
<gmd:MD_Metadata xmlns:gmd="http://www.isotc211.org/2005/gmd"
                 xmlns:gco="http://www.isotc211.org/2005/gco"
                 xmlns:gml="http://www.opengis.net/gml/3.2"
                 xmlns:gsr="http://www.isotc211.org/2005/gsr"
                 xmlns:gts="http://www.isotc211.org/2005/gts"
                 xmlns:srv="http://www.isotc211.org/2005/srv">
    
    <!-- Metadata Identifier -->
    <gmd:fileIdentifier>
        <gco:CharacterString>12345-unique-id</gco:CharacterString>
    </gmd:fileIdentifier>

    <!-- Date -->
    <gmd:dateStamp>
        <gco:Date>2025-03-07</gco:Date>
    </gmd:dateStamp>

    <!-- Spatial Reference -->
    <gsr:MD_ReferenceSystem>
        <gmd:referenceSystemIdentifier>
            <gmd:RS_Identifier>
                <gmd:code>
                    <gco:CharacterString>EPSG:4326</gco:CharacterString>
                </gmd:code>
            </gmd:RS_Identifier>
        </gmd:referenceSystemIdentifier>
    </gsr:MD_ReferenceSystem>

    <!-- Temporal Extent -->
    <gmd:extent>
        <gmd:EX_Extent>
            <gmd:temporalElement>
                <gmd:EX_TemporalExtent>
                    <gmd:extent>
                        <gts:TM_Period>
                            <gts:begin>
                                <gco:Date>2000-01-01</gco:Date>
                            </gts:begin>
                            <gts:end>
                                <gco:Date>2025-12-31</gco:Date>
                            </gts:end>
                        </gts:TM_Period>
                    </gmd:extent>
                </gmd:EX_TemporalExtent>
            </gmd:temporalElement>
        </gmd:EX_Extent>
    </gmd:extent>

    <!-- Service Metadata -->
    <srv:SV_ServiceIdentification>
        <gmd:citation>
            <gmd:CI_Citation>
                <gmd:title>
                    <gco:CharacterString>Weather Forecasting Service</gco:CharacterString>
                </gmd:title>
            </gmd:CI_Citation>
        </gmd:citation>
    </srv:SV_ServiceIdentification>

</gmd:MD_Metadata>
```

---

### **✅ Key Takeaways**
- The **ISO 19115 schema family** uses **multiple namespaces** to categorize metadata elements.
- **`gco` (Geographic Common)** provides **primitive data types**.
- **`gmd` (Geographic Metadata)** is the **core metadata module**.
- **`gml` (Geography Markup Language)** handles **spatial features**.
- **Other modules (e.g., `gsr`, `gts`, `srv`) define specialized metadata** for **reference systems, temporal data, and services**.
