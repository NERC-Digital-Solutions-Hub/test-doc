using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml {
  /// <summary>
  /// The options for the <see cref="XmlElementSerializer"/>. <see cref="XmlElementReader{T}"/> instances
  /// can be registered here to be used by the serializer. This implementation is inspired by the 
  /// <see cref="JsonSerializerOptions"/>.
  /// </summary>
  public sealed class XmlElementSerializerOptions {
    /// <summary>
    /// The <see cref="XmlElementReader"/> instances that are registered with the serializer. 
    /// </summary>
    public IList<XmlElementReader>? Readers {
      get;
      set;
    }

    /// <summary>
    /// Gets the <see cref="XmlElementReader"/> for the specified <paramref name="typeToRead"/>.
    /// </summary>
    /// <param name="typeToRead">The <see cref="Type"/> to read.</param>
    /// <returns>A <see cref="XmlElementReader"/> instance that can read the <paramref name="typeToRead"/>.</returns>
    /// <exception cref="InvalidOperationException">Thrown if no reader is found for <paramref name="typeToRead"/>.</exception>
    public XmlElementReader GetReader(Type typeToRead) {
      if (Readers == null) {
        throw new InvalidOperationException("No readers have been registered with the serializer.");
      }

      foreach (XmlElementReader reader in Readers) {
        if (reader.CanRead(typeToRead)) {
          return reader;
        }
      }

      throw new InvalidOperationException($"No reader found for type {typeToRead}.");
    }
  }
}
