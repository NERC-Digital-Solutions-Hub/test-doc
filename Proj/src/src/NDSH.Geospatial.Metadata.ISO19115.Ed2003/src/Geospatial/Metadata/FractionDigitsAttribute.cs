
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : dd/mm/2022, hh:MM, Vasilis Vlastaras.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

// TODO: Move class FractionDigitsAttribute to another assembly.

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Defines the fraction of digits attribute.
  /// </summary>
  public class FractionDigitsAttribute : ValidationAttribute {

    #region Member Variables

    private readonly uint _decimalPrecision;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="FractionDigitsAttribute"/>
    /// </summary>
    /// <param name="decimalPrecision"></param>
    public FractionDigitsAttribute(uint decimalPrecision) {
      _decimalPrecision = decimalPrecision;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Checks if an <see cref="object"/> is valid.
    /// </summary>
    /// <param name="value">The object to validate.</param>
    /// <returns>
    /// A <see cref="Boolean"/> indicating whether the object is valid or not.
    /// </returns>
    public override bool IsValid(object value) {
      if (value == null) {
        return true;
      }

      if (value is decimal) {
        return HasPrecision(value, _decimalPrecision);
      }

      if (value is float) {
        return HasPrecision(value, _decimalPrecision);
      }

      if (value is double) {
        return HasPrecision(value, _decimalPrecision);
      }

      return false;

    }

    /// <summary>
    /// Checks if an <see cref="object"/> has the indicated precision.
    /// </summary>
    /// <param name="value">The object whose precision will be checked.</param>
    /// <param name="precision">The precision under investigation.</param>
    /// <returns>
    /// A <see cref="Boolean"/> indicating whether the object has the indicated precision or not.
    /// </returns>
    private static bool HasPrecision(object value, uint precision) {

      string valueStr = String.Empty;

      if (value is decimal) {
        valueStr = ((decimal)value).ToString(CultureInfo.InvariantCulture);
      }

      if (value is float) {
        valueStr = ((float)value).ToString(CultureInfo.InvariantCulture);
      }

      if (value is double) {
        valueStr = ((double)value).ToString(CultureInfo.InvariantCulture);
      }

      int indexOfDot = valueStr.IndexOf('.');
      if (indexOfDot == -1) {
        return true;
      }

      return valueStr.Length - indexOfDot - 1 <= precision;

    }

    #endregion

  }

}
