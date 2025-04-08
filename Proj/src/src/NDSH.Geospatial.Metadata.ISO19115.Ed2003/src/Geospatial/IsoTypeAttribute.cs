
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 13/03/2025, @gisvlasta
// History           : 18/03/2025, @gisvlasta - Added WrapperName used to specify the XSD property type (type wrapper).
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial {

  /// <summary>
  /// The attribute that is used to associate a <see cref="Type"/> to an ISO type.
  /// </summary>
  [AttributeUsage(
    AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum,
    Inherited = false,
    AllowMultiple = false
  )]
  public class IsoTypeAttribute : Attribute {

    #region Imported Namespaces

    /// <summary>
    /// Initializes the<see cref = "IsoTypeAttribute" />.
    /// </summary>
    /// <param name = "name">The name to associate with the type. <b>This is required</b>.</param>
    /// <remarks>
    /// The <see cref="IsoType">IsoType</see>, <see cref="IsAbstract">IsAbstract</see>,
    /// and <see cref="IsRequired">IsRequired</see> are optional parameters.
    /// </remarks>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="name"/> is <see langword="null"/> or <c>em</c> <see cref="string.Empty"/>
    /// </exception>
    public IsoTypeAttribute(string name) {
      _name = string.IsNullOrEmpty(name)
        ? throw new ArgumentException($"{Name} is required and cannot be null or empty.", nameof(name)) // RESOURCE
        : name;
      _wrapperName = null;
      _isoType = IsoTypes.Unknown;
      _isAbstract = false;
      _isRequired = false;
    }

    #endregion

    #region Public Properties

    private string _name;

    /// <summary>
    /// Gets/Sets the name of the ISO type associated with the attribute.
    /// </summary>
    /// <remarks>This is <b>required</b> and must always be set.</remarks>
    public string Name => _name;

    private string? _wrapperName;

    /// <summary>
    /// Gets/Sets the wrapper name of the ISO type associated with the attribute.
    /// </summary>
    /// <remarks>
    /// This is <b>optional</b> and defaults to <see langword="null"/>.
    /// </remarks>
    public string? WrapperName {
      get => _wrapperName;
      set => _wrapperName = value;
    }

    private IsoTypes _isoType;

    /// <summary>
    /// Gets/Sets the <see cref="IsoTypes">IsoType</see>.
    /// </summary>
    /// <remarks>
    /// This is <b>optional</b> and defaults to <see cref="IsoTypes.Unknown"/> if not set.
    /// </remarks>
    public IsoTypes IsoType {
      get => _isoType;
      set => _isoType = value;
    }

    private bool _isAbstract;

    /// <summary>
    /// Gets/Sets whether the ISO type is abstract or not.
    /// </summary>
    /// <remarks>
    /// This is <b>optional</b> and defaults to <see langword="false"/> if not set.
    /// </remarks>
    public bool IsAbstract {
      get => _isAbstract;
      set => _isAbstract = value;
    }

    private bool _isRequired;

    /// <summary>
    /// Gets/Sets whether the ISO type is required or not.
    /// </summary>
    /// <remarks>
    /// This is <b>optional</b> and defaults to <see langword="false"/> if not set.
    /// </remarks>
    // WARNING: Replace it with an enumeration TRUE, FALSE, UNKNOWN
    public bool IsRequired {
      get => _isRequired;
      set => _isRequired = value;
    }

    #endregion

  }

}
