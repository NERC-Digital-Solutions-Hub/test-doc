
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 17/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text {

  /// <summary>
  /// Converts a <see cref="CharacterString_PropertyType"/> to a <see cref="string"/>.
  /// </summary>
  public class CharacterString_PropertyTypeConverter : ExpandableObjectConverter {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CharacterString_PropertyTypeConverter"/>.
    /// </summary>
    public CharacterString_PropertyTypeConverter()
      : base() {

    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Determines whether a <see cref="CharacterString_PropertyType"/> can be converted to a <see cref="string"/>.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/>.</param>
    /// <param name="destinationType">The destination type. (Should be <see cref="string"/>).</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether an <see cref="CharacterString_PropertyType"/>
    /// can be converted to <see cref="string"/>.
    /// </returns>
    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType) =>
      base.CanConvertTo(context, destinationType);

    /// <summary>
    /// Converts a <see cref="CharacterString_PropertyType"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/>.</param>
    /// <param name="culture">A <see cref="CultureInfo"/>.</param>
    /// <param name="value">
    /// The <see cref="CharacterString_PropertyType"/> object that needs to be converted.
    /// </param>
    /// <param name="destinationType">The destination type. (Should be <see cref="string"/>).</param>
    /// <returns>
    /// An object containing a <see cref="string"/> with the converted
    /// <see cref="CharacterString_PropertyType"/> object.
    /// </returns>
    public override object? ConvertTo(
      ITypeDescriptorContext? context,
      CultureInfo? culture,
      object? value,
      Type destinationType
    ) {

      if (!CanConvertTo(destinationType)) {
        return base.ConvertTo(context, culture, value, destinationType);
      }

      if (value == null) {
        return base.ConvertTo(context, culture, value, destinationType);
      }

      if ((value.GetType() != typeof(CharacterString_PropertyType) && destinationType != typeof(string))) {
        return base.ConvertTo(context, culture, value, destinationType);
      }

      CharacterString_PropertyType characterStringPT = (CharacterString_PropertyType)value;

      try {

        return string.IsNullOrEmpty(characterStringPT.NilReason)
          ? characterStringPT.CharacterString
          : (object)string.Format("NilReason: {0}", characterStringPT.NilReason);

      }
      catch {
        return base.ConvertTo(context, culture, value, destinationType);
      }

    }

    #endregion

  }

}
