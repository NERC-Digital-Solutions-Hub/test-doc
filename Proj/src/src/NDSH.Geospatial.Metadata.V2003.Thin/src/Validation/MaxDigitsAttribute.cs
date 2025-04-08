#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/02/2022, 20:05, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Validation {

  /// <summary>
  /// 
  /// </summary>
  public class MaxDigitsAttribute : ValidationAttribute {

    #region Private Fields

    private readonly int _max;
    private readonly int _min;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// 
    /// </summary>
    /// <param name="max"></param>
    /// <param name="min"></param>
    public MaxDigitsAttribute(int max, int min = 0) {
      _max = max;
      _min = min;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="validationContext"></param>
    /// <returns></returns>
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {

      if (!IsValid(value)) {
        return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
      }

      return null;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public override bool IsValid(object value) {

      // you could do any custom validation you like if (value is int) {
      var stringValue = "" + (int)value;
      var length = stringValue.Length;

      if (length >= _min && length <= _max) {
        return true;
      }

      return false;

    }

    #endregion

  }

}
