
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 13/03/2025, @gisvlasta - Refactored the code logic.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="doubleList">
//   <annotation>
//     <documentation>A type for a list of values of the respective simple type.</documentation>
//   </annotation>
//   <list itemType="double"/>
// </simpleType>
//
// <complexType name="MeasureListType">
//   <annotation>
//     <documentation>gml:MeasureListType provides for a list of quantities.</documentation>
//   </annotation>
//   <simpleContent>
//     <extension base="gml:doubleList">
//       <attribute name="uom" type="gml:UomIdentifier" use="required"/>
//     </extension>
//   </simpleContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.BasicTypes {

  /// <summary>
  /// The <see cref="MeasureListType"/> provides for a list of quantities, 
  /// i.e. a collection of <b>measured values</b> and their common <b>unit of measure (UOM)</b>.
  /// </summary>
  /// <example>
  /// Example XML representation:
  /// <code>
  /// &lt;MeasureListType uom="m"&gt;1.23 4.56 7.89&lt;/MeasureListType&gt;
  /// </code>
  /// </example>
  [Serializable]
  //[XmlType("MeasureListType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MeasureListType")]
  public class MeasureListType : ObservableDbEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MeasureListType"/>.
    /// </summary>
    public MeasureListType() {
      Values = [];
    }

    /// <summary>
    /// Initializes the <see cref="MeasureListType"/>.
    /// </summary>
    /// <param name="uom">
    /// The <see cref="UomIdentifier"/> representing the unit of measure (UOM) for the values.
    /// </param>
    /// <param name="values">An <see cref="ObservableCollection{Double}"/> of measurement values.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="uom"/> is <see langword="null"/> or
    /// <paramref name="values"/> is <see langword="null"/>.
    /// </exception>
    public MeasureListType(UomIdentifier uom, ObservableCollection<double> values) {

      ArgumentNullException.ThrowIfNull(uom);
      ArgumentNullException.ThrowIfNull(values);

      Uom = uom;
      Values = values;

    }

    #endregion

    #region Public Properties

    private UomIdentifier _uom;

    /// <summary>
    /// Gets/Sets the <see cref="UomIdentifier"/> which encodes the
    /// <b>unit of measure (UOM)</b> for the list of values.
    /// </summary>
    /// <remarks>
    /// This attribute is <b>required</b> and ensures that all values in the list
    /// are expressed in a <b>consistent unit</b>.
    /// </remarks>
    /// <value>A <b>valid</b> <see cref="UomIdentifier"/>, such as <c>"m"</c> for meters.</value>
    [Required]
    //[XmlAttribute("uom", DataType = "string")]
    [JsonProperty("uom")]
    public required UomIdentifier Uom {
      get => _uom;
      set => SetProperty(ref _uom, value);
    }

    private ObservableCollection<double> _values;

    /// <summary>
    /// Gets the <see cref="ObservableCollection{Double}"/> with the <b>measured values</b>.
    /// </summary>
    /// <remarks>
    /// This is a list of <see cref="double"/> values
    /// representing <b>quantities</b> in the specified UOM.
    /// </remarks>
    /// <value>
    /// An <see cref="ObservableCollection{Double}"/>.
    /// </value>
    //[XmlText()]
    [JsonProperty("values")]
    public ObservableCollection<double> Values {
      get => _values;
      set => SetProperty(ref _values, value);
    }

    #endregion

  }

  // WARNIMG: REVISIT

  // TODO: The class can be implemented as a collection itself, so it needs to implement a couple of interfaces.
  // This is because in the XSD definitions the MeasureListType is an extension of gml:doubleList

  #region Alternative Implementation - This is the preferred one if it can support Entity Framework

  ///// <summary>
  ///// Represents a **collection of measured quantities** with a **unit of measure (UOM)**.
  ///// </summary>
  ///// <remarks>
  ///// - Implements <see cref="INotifyCollectionChanged"/> to support real-time binding.
  ///// - Behaves as a **list of `double` values** (implements `IList<double>`).
  ///// - Maintains an **internal `ObservableCollection<double>` for MVVM support**.
  ///// </remarks>
  ///// <example>
  ///// Example XML representation:
  ///// <code>
  ///// &lt;MeasureListType uom="m"&gt;1.23 4.56 7.89&lt;/MeasureListType&gt;
  ///// </code>
  ///// </example>
  //[Serializable]
  //[JsonObject("MeasureListType")]
  //public class MeasureListType : ObservableDbEntity, IList<double>, IReadOnlyList<double>, INotifyCollectionChanged {
  //  #region Fields

  //  private readonly ObservableCollection<double> _values;

  //  #endregion

  //  #region Constructors

  //  /// <summary>
  //  /// Initializes a new instance of the <see cref="MeasureListType"/> class with an empty collection.
  //  /// </summary>
  //  public MeasureListType() {
  //    _values = new ObservableCollection<double>();
  //    _values.CollectionChanged += (s, e) => OnCollectionChanged(e);
  //  }

  //  /// <summary>
  //  /// Initializes the <see cref="MeasureListType"/> with a specified UOM and values.
  //  /// </summary>
  //  /// <param name="uom">The <see cref="UomIdentifier"/> representing the unit of measure (UOM).</param>
  //  /// <param name="values">A collection of measurement values.</param>
  //  /// <exception cref="ArgumentNullException">
  //  /// Thrown when <paramref name="uom"/> or <paramref name="values"/> is <see langword="null"/>.
  //  /// </exception>
  //  public MeasureListType(UomIdentifier uom, IEnumerable<double> values) {
  //    ArgumentNullException.ThrowIfNull(uom);
  //    ArgumentNullException.ThrowIfNull(values);

  //    Uom = uom;
  //    _values = new ObservableCollection<double>(values);
  //    _values.CollectionChanged += (s, e) => OnCollectionChanged(e);
  //  }

  //  #endregion

  //  #region Properties

  //  private UomIdentifier _uom;

  //  /// <summary>
  //  /// Gets or sets the **unit of measure (UOM)** for the list of values.
  //  /// </summary>
  //  /// <remarks>
  //  /// This attribute is **required** and ensures that all values are expressed in a **consistent unit**.
  //  /// </remarks>
  //  [Required]
  //  [JsonProperty("uom")]
  //  public required UomIdentifier Uom {
  //    get => _uom;
  //    set => SetProperty(ref _uom, value);
  //  }

  //  #endregion

  //  #region IList<double> Implementation

  //  /// <summary>
  //  /// Gets or sets the **measurement value at the specified index**.
  //  /// </summary>
  //  /// <param name="index">The zero-based index.</param>
  //  /// <returns>The measurement value.</returns>
  //  public double this[int index] {
  //    get => _values[index];
  //    set {
  //      if (_values[index] != value) {
  //        _values[index] = value;
  //        OnPropertyChanged(nameof(Values));
  //      }
  //    }
  //  }

  //  /// <summary>
  //  /// Gets the **number of items** in the collection.
  //  /// </summary>
  //  public int Count => _values.Count;

  //  /// <summary>
  //  /// Always `false` since this collection is modifiable.
  //  /// </summary>
  //  public bool IsReadOnly => false;

  //  /// <summary>
  //  /// Adds a new measurement value.
  //  /// </summary>
  //  /// <param name="value">The measurement value to add.</param>
  //  public void Add(double value) => _values.Add(value);

  //  /// <summary>
  //  /// Clears all values in the collection.
  //  /// </summary>
  //  public void Clear() => _values.Clear();

  //  /// <summary>
  //  /// Determines whether the collection contains a specific value.
  //  /// </summary>
  //  public bool Contains(double value) => _values.Contains(value);

  //  /// <summary>
  //  /// Copies the collection to an array.
  //  /// </summary>
  //  public void CopyTo(double[] array, int arrayIndex) => _values.CopyTo(array, arrayIndex);

  //  /// <summary>
  //  /// Returns an enumerator for the collection.
  //  /// </summary>
  //  public IEnumerator<double> GetEnumerator() => _values.GetEnumerator();

  //  /// <summary>
  //  /// Returns the index of a specific value in the collection.
  //  /// </summary>
  //  public int IndexOf(double value) => _values.IndexOf(value);

  //  /// <summary>
  //  /// Inserts a value at the specified index.
  //  /// </summary>
  //  public void Insert(int index, double value) => _values.Insert(index, value);

  //  /// <summary>
  //  /// Removes a specific value from the collection.
  //  /// </summary>
  //  public bool Remove(double value) => _values.Remove(value);

  //  /// <summary>
  //  /// Removes the value at the specified index.
  //  /// </summary>
  //  public void RemoveAt(int index) => _values.RemoveAt(index);

  //  /// <summary>
  //  /// Returns an enumerator for non-generic iteration.
  //  /// </summary>
  //  IEnumerator IEnumerable.GetEnumerator() => _values.GetEnumerator();

  //  #endregion

  //  #region INotifyCollectionChanged Implementation

  //  /// <summary>
  //  /// Occurs when the collection changes (items added, removed, moved, or reset).
  //  /// </summary>
  //  public event NotifyCollectionChangedEventHandler? CollectionChanged;

  //  /// <summary>
  //  /// Raises the <see cref="CollectionChanged"/> event.
  //  /// </summary>
  //  protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) {
  //    CollectionChanged?.Invoke(this, e);
  //  }

  //  #endregion

  //}

  #endregion

}
