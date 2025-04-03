
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/02/2023, @gisvlasta
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Validation {

  public class MaxDigitsAttribute : ValidationAttribute {

    #region Private Fields

    private readonly int _max;
    private readonly int _min;

    #endregion

    #region Constructors - Destructors

    public MaxDigitsAttribute(int max, int min = 0) {
      _max = max;
      _min = min;
    }

    #endregion

    #region Public Methods

    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
      if (!IsValid(value)) {
        return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
      }

      return null;
    }

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
