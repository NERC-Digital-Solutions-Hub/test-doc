
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 14:59, @gisvlasta.
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
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Validation {

  /// <summary>
  /// 
  /// </summary>
  public class FractionDigitsAttribute : ValidationAttribute {

    #region Private Fields

    private readonly uint _decimalPrecision;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// 
    /// </summary>
    /// <param name="decimalPrecision"></param>
    public FractionDigitsAttribute(uint decimalPrecision) {
      _decimalPrecision = decimalPrecision;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
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
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="precision"></param>
    /// <returns></returns>
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
