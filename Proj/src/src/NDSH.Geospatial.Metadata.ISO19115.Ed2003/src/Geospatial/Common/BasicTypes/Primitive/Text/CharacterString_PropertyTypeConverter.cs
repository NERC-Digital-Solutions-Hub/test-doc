
//#region Header
//// ---------------------------------------------------------------------------------------------------------------------
//// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
//// Created           : 17/01/2023, @gisvlasta
//// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
//// License           : MIT Licence
//// Copyright         : 
////
//// Comments          : 
//// ---------------------------------------------------------------------------------------------------------------------
//#endregion

//#region Imported Namespaces

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//#endregion

//namespace NDSH.Geospatial.Metadata.ConceptualSchema.Primitive.Text {

//  // WARNING: Check if the CharacterString_PropertyTypeConverter has any value, now that there are is no PropertyType associated with the CharacterString

//  /// <summary>
//  /// Converts a <see cref="CharacterString"/> to a <see cref="string"/>.
//  /// </summary>
//  public class CharacterString_PropertyTypeConverter : ExpandableObjectConverter {

//    #region Constructors - Destructors

//    /// <summary>
//    /// Initializes the <see cref="CharacterString_PropertyTypeConverter"/>.
//    /// </summary>
//    public CharacterString_PropertyTypeConverter()
//      : base() {

//    }

//    #endregion

//    #region Public Methods

//    /// <summary>
//    /// Determines whether a <see cref="CharacterString"/> can be converted to a <see cref="string"/>.
//    /// </summary>
//    /// <param name="context">An <see cref="ITypeDescriptorContext"/>.</param>
//    /// <param name="destinationType">The destination type. (Should be <see cref="string"/>).</param>
//    /// <returns>
//    /// A <see cref="bool"/> indicating whether an <see cref="CharacterString"/>
//    /// can be converted to <see cref="string"/>.
//    /// </returns>
//    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType) =>
//      base.CanConvertTo(context, destinationType);

//    /// <summary>
//    /// Converts a <see cref="CharacterString"/> to a <see cref="string"/>.
//    /// </summary>
//    /// <param name="context">An <see cref="ITypeDescriptorContext"/>.</param>
//    /// <param name="culture">A <see cref="CultureInfo"/>.</param>
//    /// <param name="value">
//    /// The <see cref="CharacterString"/> object that needs to be converted.
//    /// </param>
//    /// <param name="destinationType">The destination type. (Should be <see cref="string"/>).</param>
//    /// <returns>
//    /// An object containing a <see cref="string"/> with the converted
//    /// <see cref="CharacterString"/> object.
//    /// </returns>
//    public override object? ConvertTo(
//      ITypeDescriptorContext? context,
//      CultureInfo? culture,
//      object? value,
//      Type destinationType
//    ) {

//      if (!CanConvertTo(destinationType)) {
//        return base.ConvertTo(context, culture, value, destinationType);
//      }

//      if (value == null) {
//        return base.ConvertTo(context, culture, value, destinationType);
//      }

//      if (value.GetType() != typeof(CharacterString) && destinationType != typeof(string)) {
//        return base.ConvertTo(context, culture, value, destinationType);
//      }

//      CharacterString characterString = (CharacterString)value;

//      try {

//        return string.IsNullOrEmpty(characterString.NilReason) ?
//          characterString.Value : (object)string.Format("NilReason: {0}", characterString.NilReason); // RESOURCE

//      }
//      catch {
//        return base.ConvertTo(context, culture, value, destinationType);
//      }

//    }

//    #endregion

//  }

//}
