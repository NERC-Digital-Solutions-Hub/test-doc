
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 17/01/2023, 21:12, @gisvlasta.
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
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text {

  /// <summary>
  /// Converts a <see cref="CharacterString"/> to a <see cref="string"/>.
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
    /// Determines whether a <see cref="CharacterString"/> can be converted to a <see cref="string"/>.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/>.</param>
    /// <param name="destinationType">The destination type. (Should be <see cref="string"/>).</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether an <see cref="CharacterString"/>
    /// can be converted to <see cref="string"/>.
    /// </returns>
    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType) {
      return base.CanConvertTo(context, destinationType);
    }

    /// <summary>
    /// Converts a <see cref="CharacterString"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/>.</param>
    /// <param name="culture">A <see cref="CultureInfo"/>.</param>
    /// <param name="value">The <see cref="CharacterString"/> object that needs to be converted.</param>
    /// <param name="destinationType">The destination type. (Should be <see cref="string"/>).</param>
    /// <returns>
    /// An object containing a <see cref="string"/> with the converted <see cref="CharacterString"/> object.
    /// </returns>
    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType) {
      
      if (!CanConvertTo(destinationType)) {
        return base.ConvertTo(context, culture, value, destinationType);
      }

      if (value == null) {
        return base.ConvertTo(context, culture, value, destinationType);
      }

      if ((value.GetType() != typeof(CharacterString) && destinationType != typeof(string))) {
        return base.ConvertTo(context, culture, value, destinationType);
      }

      CharacterString_PropertyType characterStringPT = (CharacterString_PropertyType)value;

      try {

        if (String.IsNullOrEmpty(characterStringPT.NilReason)) {
          return characterStringPT.CharacterString;
        }

        return string.Format("NilReason: {0}", characterStringPT.NilReason);

      }
      catch {
        return base.ConvertTo(context, culture, value, destinationType);
      }

    }

    #endregion

  }

}
