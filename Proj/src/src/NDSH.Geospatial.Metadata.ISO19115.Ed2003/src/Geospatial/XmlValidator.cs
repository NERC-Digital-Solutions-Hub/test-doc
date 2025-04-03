using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial {

  public static class XmlValidator {

    /// <summary>
    /// Validates that a string conforms to XML ID constraints.
    /// </summary>
    /// <param name="id">The string to validate.</param>
    /// <returns><c>true</c> if the string is a valid XML ID; otherwise, <c>false</c>.</returns>
    // WARNING: Check out that this validator is correct !!!
    public static bool IsValidXmlId(string id) {
      if (string.IsNullOrWhiteSpace(id)) {
        return false;
      }
      if (!char.IsLetter(id[0])) {
        return false;
      }

      // XML ID should only contain letters, digits, hyphens, underscores, or periods
      return id.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_' || c == '.');
    }

  }

}
