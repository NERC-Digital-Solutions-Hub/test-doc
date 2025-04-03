
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.Validation {

  public class FractionDigitsAttribute : ValidationAttribute {

    #region Private Fields

    private readonly uint _decimalPrecision;

    #endregion

    #region Constructors - Destructors

    public FractionDigitsAttribute(uint decimalPrecision) {
      _decimalPrecision = decimalPrecision;
    }

    #endregion

    #region Public Methods

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

    private static bool HasPrecision(object value, uint precision) {

      string valueStr = string.Empty;

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
