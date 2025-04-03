
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Defines the maximum number of digits allowed.
  /// </summary>
  public class MaxDigitsAttribute : ValidationAttribute {

    // TODO: This attribute must be moved to a different assembly file.

    #region Member Variables

    private readonly int _max;
    private readonly int _min;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MaxDigitsAttribute"/>.
    /// </summary>
    /// <param name="max">The maximum digits.</param>
    /// <param name="min">The minimum digits.</param>
    public MaxDigitsAttribute(int max, int min = 0) {
      _max = max;
      _min = min;
    }

    #endregion

    #region Protected Methods

    /// <summary>
    /// Checks if <see cref="object"/> is valid.
    /// </summary>
    /// <param name="value">The object to validate.</param>
    /// <param name="validationContext">A <see cref="ValidationContext"/> to use in the validation.</param>
    /// <returns>
    /// A <see cref="ValidationResult"/> object holding the result of the validation.
    /// </returns>
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {

      if (!IsValid(value)) {
        return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
      }

      return null;

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
