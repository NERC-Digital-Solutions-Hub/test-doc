
# Naming ISO Geographic Metadata Assemblies and Namespaces

## Discussion
Below is a table with **four** ISO 19115 “versions” or parts, each with a **suggested**
namespace that avoids underscores in favor of a more natural “Part”/“Ed” naming scheme.
This approach keeps the naming valid in C#, descriptive (including the standard part and the edition year),
and consistent across multiple parts/editions. 

> **Note:** Since C# namespaces cannot start with digits or contain hyphens (`-`),
the “19115-2” is transformed into “19115Part2” and so on.
Also, the “Ed2003” (short for “Edition 2003”) is used rather than “V2003” or underscores.

---

## Assembly Naming

| **ISO Standard**          | **Year** | **Official Title**                                              | **Suggested C# Library**                                      |
|---------------------------|----------|-----------------------------------------------------------------|------------------------------------------------------------------|
| **ISO 19115:2003**        | 2003     | _Geographic Information — Metadata_                             | `NDSH.Geospatial.Metadata.ISO19115.Ed2003`                      |
| **ISO 19115-2:2009**      | 2009     | _Extensions for imagery and gridded data_                       | `NDSH.Geospatial.Metadata.ISO19115Part2.Ed2009`                 |
| **ISO 19115-1:2014**      | 2014     | _Fundamentals_ (revision of ISO 19115:2003)                     | `NDSH.Geospatial.Metadata.ISO19115Part1.Ed2014`                 |
| **ISO 19115-3:2016**      | 2016     | _XML Schema Implementation for Fundamental Concepts_            | `NDSH.Geospatial.Metadata.ISO19115Part3.Ed2016`                 |

### Why this pattern?
1. **Avoiding underscores**: Underscores (`_`) are not typical in .NET namespaces and can feel cluttered.  
2. **Avoiding digits/hyphens at the start**: C# does not allow identifiers to begin with digits or contain hyphens,
   so “19115-2” needs a transformation.  
3. **Preserving clarity**: Including `ISO19115Part2` or `ISO19115Part3`
   still preserves direct reference to the ISO part.  
4. **Using “EdYYYY”**: The suffix `Ed2003` (for “Edition 2003”)
   is more descriptive than “v2003” and avoids underscores.

### Variations that can be considered
- **Use a sub-namespace for the part**:  
  \`NDSH.Geospatial.Metadata.ISO19115.Part2.Ed2009\`  
  This introduces one more level, but it is still valid if it is preferred each part to be a distinct folder.  
- **Shorten “Metadata”** if the project has deep nesting**:  
  \`NDSH.Geo.Metadata.ISO19115.Ed2003\`  
- **Use “EditionYYYY” instead of “EdYYYY”** if more clarity is preferred**:  
  \`NDSH.Geospatial.Metadata.ISO19115.Edition2003\`

Any of these variants can work.
What matters most is a **consistent** style to be maintained with meaningful hierarchy for future-proofing.


