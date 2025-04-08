
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/02/2023, 10:53, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin {

  /// <summary>
  /// The ExtensionMethods class provides utility exension methods.
  /// </summary>
  public static class ExtensionMethods {

    /// <summary>
    /// Gets the Xml <see cref="Enum"/> name of an <see cref="Enum"/> value.
    /// </summary>
    /// <typeparam name="T">The Enum type.</typeparam>
    /// <param name="enumValue">The Enum value.</param>
    /// <returns>A <see cref="string"/> with the name of the <see cref="Enum"/> value.</returns>
    /// <remarks>
    /// The method checks if the <see cref="Enum"/> value is decorated with an <see cref="XmlEnumAttribute"/>.
    /// </remarks>
    // TODO: Check the quality of this XML Documentation.
    public static string GetXmlEnumName<T>(this T enumValue) where T : struct, IConvertible {
      
      string enumName = null;

      Type type = enumValue.GetType();
      
      if (type.IsEnum) {
        FieldInfo? fieldInfo = type.GetField(Enum.GetName(type, enumValue));
        object[] xmlEnumAttributes = fieldInfo?.GetCustomAttributes(typeof(XmlEnumAttribute), false);

        if (xmlEnumAttributes is not null) {
          if (xmlEnumAttributes.Length != 0) {
            XmlEnumAttribute xmlEnumAttribute = (XmlEnumAttribute)xmlEnumAttributes[0];
            enumName = xmlEnumAttribute.Name;
          }
        }
      }
      
      return enumName;

    }

  }

}
