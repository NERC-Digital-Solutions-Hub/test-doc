
#region Impoerted namespaces

using NDSH.Geospatial.Metadata.V2005;
using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Serializers {

  /// <summary>
  /// 
  /// </summary>
  public class GeoNetworkGmd2005Serializer : XmlSerializer {

    #region Member Variables

    private Dictionary<string, Func<object, string>> serializeDictionary;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// 
    /// </summary>
    public GeoNetworkGmd2005Serializer() : base() {

      //XmlSerializer.Equals();
      //XmlSerializer.FromMappings();
      //XmlSerializer.FromTypes();
      //XmlSerializer.GetXmlSerializerAssemblyName();
      //XmlSerializer.ReferenceEquals();

      //XmlSerializer xs;
      //xs.CanDeserialize();
      //xs.Deserialize();
      //xs.Equals();
      //xs.GetHashCode();
      //xs.GetType();
      //xs.Serialize();
      //xs.ToString();
      //xs.UnknownAttribute;
      //xs.UnknownElement;
      //xs.UnknownNode;
      //xs.UnreferencedObject;

    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GeoNetworkGmd2005Serializer"/>
    /// that can serialize objects of the specified type into XML documents,
    /// and deserialize object of the specified type./>
    /// </summary>
    /// <param name="type">
    /// The <see cref="Type"/> of the object that this <see cref="GeoNetworkGmd2005Serializer"/> can serialize.
    /// </param>
    public GeoNetworkGmd2005Serializer(Type type) : base(type) {

    }

    #endregion

    #region Public Methods
    
    /// <summary>
    /// Serializes the specified <see cref="Object"/> and writes the XML
    /// document to a file using the specified <see cref="Stream"/>.
    /// </summary>
    /// <param name="stream">The <see cref="Stream"/> used to write the object.</param>
    /// <param name="o">the <see cref="object"/> to serialize.</param>
    public new void Serialize(Stream stream, object? o) {

      System.Diagnostics.Debug.WriteLine("new serialize | Stream");

      //Entity entity = (Entity)o; // TODO: REMOVE Entity

      //// TODO: Check null here.
      //if (entity.Item.GetType() == typeof(CI_Address)) {

      //  XElement xAddress = GetCI_AddressXElement(entity.Item);

      //  xAddress.Save(stream);
        
      //  System.Diagnostics.Debug.WriteLine("new ci_address | Stream");

      //  return;
        
      //}

      base.Serialize(stream, o);

    }

    /// <summary>
    /// Serializes the specified <see cref="Object"/> and writes the XML
    /// document to a file using the specified <see cref="TextWriter"/>.
    /// </summary>
    /// <param name="textWriter">The <see cref="TextWriter"/> used to write the XML document.</param>
    /// <param name="o">The <see cref="Object"/> to serialize.</param>
    public new void Serialize(TextWriter textWriter, object? o) {

      System.Diagnostics.Debug.WriteLine("new serialize | textWriter");

      //Entity entity = (Entity)o; // TODO: REMOVE Entity

      //// TODO: Check null here.
      //if (entity.Item.GetType() == typeof(CI_Address)) {

      //  XElement xAddress = GetCI_AddressXElement(entity.Item);

      //  xAddress.Save(textWriter);

      //  System.Diagnostics.Debug.WriteLine("new ci_address | textWriter");

      //  return;

      //}

      base.Serialize(textWriter, o);

    }

    /// <summary>
    /// Serializes the specified <see cref="Object"/> and writes the XML
    /// document to a file using the specified <see cref="XmlWriter"/>.
    /// </summary>
    /// <param name="xmlWriter">The <see cref="XmlWriter"/> used to write the XML document.</param>
    /// <param name="o">The <see cref="Object"/> to serialize.</param>
    public new void Serialize(XmlWriter xmlWriter, object? o) {

      System.Diagnostics.Debug.WriteLine("new serialize | XmlWriter");

      //Entity entity = (Entity)o; // TODO: REMOVE Entity

      //// TODO: Check null here.
      //if (entity.Item.GetType() == typeof(CI_Address)) {

      //  XElement xAddress = GetCI_AddressXElement(entity.Item);

      //  xAddress.Save(xmlWriter);
      //  xmlWriter.Close();

      //  System.Diagnostics.Debug.WriteLine("new ci_address | XmlWriter");

      //  return;

      //  //string xml = xAddress.ToString(SaveOptions.None);
      //  //string xml = xAddress.ToString(SaveOptions.DisableFormatting);

      //}

      base.Serialize(xmlWriter, o);

    }

    /// <summary>
    /// Serializes the specified <see cref="Object"/> and writes the XML document to a file
    /// using the specified <see cref="Stream"/> that references the specified namespaces.
    /// </summary>
    /// <param name="stream">The <see cref="Stream"/> used to write the XML document.</param>
    /// <param name="o">The <see cref="Object"/> to serialize.</param>
    /// <param name="namespaces">The <see cref="XmlSerializerNamespaces"/> referenced by the object.</param>
    public new void Serialize(Stream stream, object? o, XmlSerializerNamespaces? namespaces) {

      throw new NotImplementedException(); // TODO: NotImplementedException()

      //System.Diagnostics.Debug.WriteLine("new serialize | Stream, XmlSerializerNamespaces");

      //Entity entity = (Entity)o; // TODO: REMOVE Entity

      //// TODO: Check null here.
      //if (entity.Item.GetType() == typeof(CI_Address)) {

      //  XElement xAddress = GetCI_AddressXElement(entity.Item);
      //  // TODO: !!! Use the XmlSerializerNamespaces !!!
      //  xAddress.Save(stream);

      //  System.Diagnostics.Debug.WriteLine("new ci_address | Stream, XmlSerializerNamespaces");

      //  return;

      //}

      //base.Serialize(stream, o, namespaces);

    }

    /// <summary>
    /// Serializes the specified <see cref="Object"/> and writes the XML document to a file
    /// using the specified TextWriter and references the specified namespaces.
    /// </summary>
    /// <param name="textWriter">The <see cref="TextWriter"/> used to write the XML document.</param>
    /// <param name="o">the <see cref="Object"/> to serialize.</param>
    /// <param name="namespaces">The XmlSerializerNamespaces that contains namespaces for the generated XML document.</param>
    public new void Serialize(TextWriter textWriter, object? o, XmlSerializerNamespaces? namespaces) {

      throw new NotImplementedException(); // TODO: NotImplementedException()

      //System.Diagnostics.Debug.WriteLine("new serialize | textWriter, XmlSerializerNamespaces");

      //Entity entity = (Entity)o; // TODO: REMOVE Entity

      //// TODO: Check null here.
      //if (entity.Item.GetType() == typeof(CI_Address)) {

      //  XElement xAddress = GetCI_AddressXElement(entity.Item);
      //  // TODO: !!! Use the XmlSerializerNamespaces !!!
      //  xAddress.Save(textWriter);

      //  System.Diagnostics.Debug.WriteLine("new ci_address | textWriter, XmlSerializerNamespaces");

      //  return;

      //}

      //base.Serialize(textWriter, o, namespaces);

    }

    /// <summary>
    /// Serializes the specified <see cref="Object"/> and writes the XML document to a file
    /// using the specified XmlWriter and references the specified namespaces.
    /// </summary>
    /// <param name="xmlWriter">The <see cref="XmlWriter"/> used to write the XML document.</param>
    /// <param name="o">The <see cref="Object"/> to serialize.</param>
    /// <param name="namespaces">The <see cref="XmlSerializerNamespaces"/> referenced by the object.</param>
    public new void Serialize(XmlWriter xmlWriter, object? o, XmlSerializerNamespaces? namespaces) {

      // TODO: NotImplementedException();
      //throw new NotImplementedException();

      System.Diagnostics.Debug.WriteLine("new serialize | XmlWriter");

      //if (o != null) {
      //  if (o.GetType() == typeof(Entity)) {
      //    Entity entity = (Entity)o; // TODO: REMOVE Entity

      //    if (entity.Item != null) {
      //      // TODO: Check null here.
      //      if (entity.Item.GetType() == typeof(CI_Address)) {

      //        XElement xAddress = GetCI_AddressXElement(entity.Item);

      //        // TODO: !!! Use the XmlSerializerNamespaces !!!
      //        XNamespace[] xNamespaces = new XNamespace[namespaces.Count];
      //        XmlQualifiedName[] xqns = namespaces.ToArray();

      //        for (int i = 0; i < xqns.Length; i++) {
      //          xNamespaces[i] = XNamespace.Get(xqns[i].Namespace);
      //        }

      //        xAddress.Save(xmlWriter);
      //        xmlWriter.Close();

      //        System.Diagnostics.Debug.WriteLine("new ci_address | XmlWriter");

      //        return;

      //      }
      //    }
      //  }
      //}
      
      base.Serialize(xmlWriter, o, namespaces);

    }

    /// <summary>
    /// Serializes the specified <see cref="Object"/> and writes the XML document to a file
    /// using the specified <see cref="XmlWriter"/> and references the specified namespaces and encoding style.
    /// </summary>
    /// <param name="xmlWriter">The <see cref="XmlWriter"/> used to write the XML document.</param>
    /// <param name="o">The object to serialize.</param>
    /// <param name="namespaces">The <see cref="XmlSerializerNamespaces"/> referenced by the object.</param>
    /// <param name="encodingStyle">The encoding style of the serialized XML.</param>
    public new void Serialize(XmlWriter xmlWriter, object? o, XmlSerializerNamespaces? namespaces, string? encodingStyle) {
      throw new NotImplementedException(); // TODO: NotImplementedException()
    }

    /// <summary>
    /// Serializes the specified <see cref="Object"/> and writes the XML document to a file
    /// using the specified <see cref="XmlWriter"/>, XML namespaces, and encoding.
    /// </summary>
    /// <param name="xmlWriter">The <see cref="XmlWriter"/> used to write the XML document.</param>
    /// <param name="o">The object to serialize.</param>
    /// <param name="namespaces">The <see cref="XmlSerializerNamespaces"/> referenced by the object.</param>
    /// <param name="encodingStyle">The encoding style of the serialized XML.</param>
    /// <param name="id">For SOAP encoded messages, the base used to generate id attributes.</param>
    public new void Serialize(XmlWriter xmlWriter, object? o, XmlSerializerNamespaces? namespaces, string? encodingStyle, string? id) {
      throw new NotImplementedException(); // TODO: NotImplementedException()
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    /// <param name="writer"></param>
    protected override void Serialize(object? o, XmlSerializationWriter writer) {
      
      //if (o.GetType() == typeof(CI_Address)) {

      //  CI_Address address = (CI_Address)o;

      //  string gmdNS = "http://www.isotc211.org/2005/gmd";
      //  string gcoNS = "http://www.isotc211.org/2005/gco";

      //  XAttribute gmdXAttribute = new XAttribute(XNamespace.Xmlns + "gmd", gmdNS);
      //  XAttribute gcoXAttribute = new XAttribute(XNamespace.Xmlns + "gco", gcoNS);

      //  XName characterStringXName = XName.Get("CharacterString", gmdNS);

      //  XName addressXName = XName.Get("CI_Address", gmdNS);

      //  XName deliveryPointXName = XName.Get("deliveryPoint", gmdNS);
      //  XName cityXName = XName.Get("city", gmdNS);
      //  XName administrativeAreaXName = XName.Get("administrativeArea", gmdNS);
      //  XName postalCodeXName = XName.Get("postalCode", gmdNS);
      //  XName countryXName = XName.Get("country", gmdNS);
      //  XName electronicMailAddressXName = XName.Get("electronicMailAddress", gmdNS);

      //  XElement xAddress = new XElement(addressXName, gmdXAttribute,
      //    new XElement(deliveryPointXName,
      //      new XElement(characterStringXName, gcoXAttribute, address.DeliveryPoint)
      //    ),
      //    new XElement(cityXName,
      //      new XElement(characterStringXName, gcoXAttribute, address.City)
      //    ),
      //    new XElement(administrativeAreaXName,
      //      new XElement(characterStringXName, gcoXAttribute, address.AdministrativeArea)
      //    ),
      //    new XElement(postalCodeXName,
      //      new XElement(characterStringXName, gcoXAttribute, address.PostalCode)
      //    ),
      //    new XElement(countryXName,
      //      new XElement(characterStringXName, gcoXAttribute, address.Country)
      //    ),
      //    new XElement(electronicMailAddressXName,
      //      new XElement(characterStringXName, gcoXAttribute, address.ElectronicMailAddress)
      //    )
      //  );

      //writer.

      //xAddress.Save(writer);

      //string xml = xAddress.ToString(SaveOptions.None);
      //string xml = xAddress.ToString(SaveOptions.DisableFormatting);

      //}

      //CharacterString characterString = new CharacterString();
      //characterString.Value = "koula";
      //base.Serialize(characterString, writer);

      System.Diagnostics.Debug.WriteLine("protected serialize");
      base.Serialize(o, writer);

    }

    /// <summary>
    /// Deserializes the XML document contained by the specified <see cref="Stream"/>.
    /// </summary>
    /// <param name="stream">
    /// The <see cref="Stream"/> that contains the XML document to deserialize.
    /// </param>
    /// <returns>The <see cref="Object"/> being deserialized.</returns>
    public new object? Deserialize(Stream stream) {
      throw new NotImplementedException(); // TODO: NotImplementedException()
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified <see cref="TextReader"/>.
    /// </summary>
    /// <param name="textReader">
    /// The <see cref="TextReader"/> that contains the XML document to deserialize.
    /// </param>
    /// <returns>The <see cref="Object"/> being deserialized.</returns>
    public new object? Deserialize(TextReader textReader) {
      throw new NotImplementedException(); // TODO: NotImplementedException()
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified <see cref="XmlSerializationReader"/>.
    /// </summary>
    /// <param name="reader">
    /// The <see cref="XmlSerializationReader"/> that contains the XML document to deserialize.
    /// </param>
    /// <returns>The deserialized object.</returns>
    protected override object Deserialize(XmlSerializationReader reader) {
      return base.Deserialize(reader);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified <see cref="XmlReader"/>.
    /// </summary>
    /// <param name="xmlReader">
    /// The <see cref="XmlReader"/> that contains the XML document to deserialize.
    /// </param>
    /// <returns>The <see cref="Object"/> being deserialized.</returns>
    public new object? Deserialize(XmlReader xmlReader) {
      throw new NotImplementedException(); // TODO: NotImplementedException()
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified
    /// <see cref="XmlReader"/> and encoding style.
    /// </summary>
    /// <param name="xmlReader">
    /// The <see cref="XmlReader"/> that contains the XML document to deserialize.
    /// </param>
    /// <param name="encodingStyle">The encoding style of the serialized XML.</param>
    /// <returns>The deserialized object.</returns>
    public new object? Deserialize(XmlReader xmlReader, string? encodingStyle) {
      throw new NotImplementedException(); // TODO: NotImplementedException()
    }

    /// <summary>
    /// Deserializes an XML document contained by the specified <see cref="XmlReader"/> and
    /// allows the overriding of events that occur during deserialization.
    /// </summary>
    /// <param name="xmlReader">
    /// The <see cref="XmlReader"/> that contains the document to deserialize.
    /// </param>
    /// <param name="events">An instance of the <see cref="XmlDeserializationEvents"/> class.</param>
    /// <returns>The <see cref="Object"/> being deserialized.</returns>
    public new object? Deserialize(XmlReader xmlReader, XmlDeserializationEvents events) {
      throw new NotImplementedException(); // TODO: NotImplementedException()
    }

    /// <summary>
    /// Deserializes the object using the data contained by the specified <see cref="XmlReader"/>.
    /// </summary>
    /// <param name="xmlReader">
    /// An instance of the <see cref="XmlReader"/> class used to read the document.
    /// </param>
    /// <param name="encodingStyle">The encoding used.</param>
    /// <param name="events">An instance of the <see cref="XmlDeserializationEvents"/> class.</param>
    /// <returns>The <see cref="Object"/> being deserialized.</returns>
    public object? Deserialize(XmlReader xmlReader, string? encodingStyle, XmlDeserializationEvents events) {
      throw new NotImplementedException(); // TODO: NotImplementedException()
    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    /// <returns></returns>
    private XElement GetCI_AddressXElement(object o) {

      CI_Address address = (CI_Address)o;

      string gmdNS = "http://www.isotc211.org/2005/gmd";
      string gcoNS = "http://www.isotc211.org/2005/gco";

      XAttribute gmdXAttribute = new XAttribute(XNamespace.Xmlns + "gmd", gmdNS);
      XAttribute gcoXAttribute = new XAttribute(XNamespace.Xmlns + "gco", gcoNS);

      XName characterStringXName = XName.Get("CharacterString", gcoNS);

      XName addressXName = XName.Get("CI_Address", gmdNS);

      XName deliveryPointXName = XName.Get("deliveryPoint", gmdNS);
      XName cityXName = XName.Get("city", gmdNS);
      XName administrativeAreaXName = XName.Get("administrativeArea", gmdNS);
      XName postalCodeXName = XName.Get("postalCode", gmdNS);
      XName countryXName = XName.Get("country", gmdNS);
      XName electronicMailAddressXName = XName.Get("electronicMailAddress", gmdNS);

      XElement xAddress = new XElement(addressXName, gmdXAttribute,
        new XElement(deliveryPointXName,
          new XElement(characterStringXName, gcoXAttribute, address.DeliveryPoint)
        ),
        new XElement(cityXName,
          new XElement(characterStringXName, gcoXAttribute, address.City)
        ),
        new XElement(administrativeAreaXName,
          new XElement(characterStringXName, gcoXAttribute, address.AdministrativeArea)
        ),
        new XElement(postalCodeXName,
          new XElement(characterStringXName, gcoXAttribute, address.PostalCode)
        ),
        new XElement(countryXName,
          new XElement(characterStringXName, gcoXAttribute, address.Country)
        ),
        new XElement(electronicMailAddressXName,
          new XElement(characterStringXName, gcoXAttribute, address.ElectronicMailAddress)
        )
      );

      return xAddress;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    /// <returns></returns>
    private XElement GetCI_AddressXElementReflect(object o) {

      //System.Reflection.Assembly;
      //System.Reflection.AssemblyExtensions;
      //System.Reflection.AssemblyName;
      //System.Reflection.Binder;
      //System.Reflection.ConstructorInfo;
      //System.Reflection.CustomAttributeData;
      //System.Reflection.CustomAttributeExtensions;
      //System.Reflection.Emit.AssemblyBuilder;
      //System.Reflection.Emit.ConstructorBuilder;
      //System.Reflection.Emit.CustomAttributeBuilder;
      //System.Reflection.Emit.EnumBuilder;
      //System.Reflection.Emit.EventBuilder;
      //System.Reflection.Emit.FieldBuilder;
      //System.Reflection.Emit.GenericTypeParameterBuilder;
      //System.Reflection.Emit.MethodBuilder;
      //System.Reflection.Emit.ModuleBuilder;
      //System.Reflection.Emit.ParameterBuilder;
      //System.Reflection.Emit.PropertyBuilder;
      //System.Reflection.Emit.TypeBuilder;
      //System.Reflection.EventAttributes;
      //System.Reflection.EventInfo;
      //System.Reflection.EventInfoExtensions;
      //System.Reflection.FieldAttributes;
      //System.Reflection.FieldInfo;
      //System.Reflection.GenericParameterAttributes;
      //System.Reflection.ICustomAttributeProvider;
      //System.Reflection.ICustomTypeProvider;
      //System.Reflection.InterfaceMapping;
      //System.Reflection.LocalVariableInfo;
      //System.Reflection.ManifestResourceInfo;
      //System.Reflection.MemberFilter;
      //System.Reflection.MemberInfo;
      //System.Reflection.MemberInfoExtensions;
      //System.Reflection.MemberTypes;
      //System.Reflection.MethodAttributes;
      //System.Reflection.MethodBase;
      //System.Reflection.MethodBody;
      //System.Reflection.MethodImplAttributes;
      //System.Reflection.MethodImportAttributes;
      //System.Reflection.MethodInfo;
      //System.Reflection.MethodInfoExtensions;
      //System.Reflection.MethodSemanticsAttributes;
      //System.Reflection.Missing;
      //System.Reflection.Module;
      //System.Reflection.ModuleExtensions;
      //System.Reflection.NullabilityInfo;
      //System.Reflection.NullabilityInfoContext;
      //System.Reflection.NullabilityState;
      //System.Reflection.ParameterAttributes;
      //System.Reflection.ParameterInfo;
      //System.Reflection.ParameterModifier;
      //System.Reflection.Pointer;
      //System.Reflection.PropertyAttributes;
      //System.Reflection.PropertyInfo;
      //System.Reflection.PropertyInfoExtensions;
      //System.Reflection.ReflectionContext;
      //System.Reflection.ResourceAttributes;
      //System.Reflection.ResourceLocation;
      //System.Reflection.RuntimeReflectionExtensions;
      //System.Reflection.TypeAttributes;
      //System.Reflection.TypeDelegator;
      //System.Reflection.TypeExtensions;
      //System.Reflection.TypeInfo;

      //System.ComponentModel.AttributeCollection;
      //System.ComponentModel.AttributeProviderAttribute;
      //System.ComponentModel.BooleanConverter;
      //System.ComponentModel.ByteConverter;
      //System.ComponentModel.CharConverter;
      //System.ComponentModel.CollectionConverter;
      //System.ComponentModel.ComplexBindingPropertiesAttribute;
      //System.ComponentModel.DateTimeConverter;
      //System.ComponentModel.DateTimeOffsetConverter;
      //System.ComponentModel.DecimalConverter;
      //System.ComponentModel.DefaultPropertyAttribute;
      //System.ComponentModel.DefaultValueAttribute;
      //System.ComponentModel.DoubleConverter;
      //System.ComponentModel.EnumConverter;
      //System.ComponentModel.EventDescriptor;
      //System.ComponentModel.EventDescriptorCollection;
      //System.ComponentModel.ExpandableObjectConverter;
      //System.ComponentModel.ExtenderProvidedPropertyAttribute;
      //System.ComponentModel.GuidConverter;

      //System.ComponentModel.ICustomTypeDescriptor;
      //System.ComponentModel.ImmutableObjectAttribute;
      //System.ComponentModel.InheritanceAttribute;
      //System.ComponentModel.ITypeDescriptorContext;
      //System.ComponentModel.MaskedTextProvider;
      //System.ComponentModel.MemberDescriptor;
      //System.ComponentModel.MergablePropertyAttribute;
      //System.ComponentModel.MultilineStringConverter;
      //System.ComponentModel.NestedContainer;
      //System.ComponentModel.NotifyParentPropertyAttribute;
      //System.ComponentModel.NullableConverter;
      //System.ComponentModel.ParenthesizePropertyNameAttribute;

      //System.ComponentModel.PropertyDescriptor;
      //System.ComponentModel.PropertyDescriptorCollection;
      //System.ComponentModel.PropertyTabAttribute;

      //System.ComponentModel.ProvidePropertyAttribute;
      //System.ComponentModel.ReferenceConverter;
      //System.ComponentModel.StringConverter;
      //System.ComponentModel.TimeSpanConverter;

      //System.ComponentModel.TypeConverter;
      //System.ComponentModel.TypeConverterAttribute;
      //System.ComponentModel.TypeDescriptionProvider;
      //System.ComponentModel.TypeDescriptionProviderAttribute;
      //System.ComponentModel.TypeDescriptor;
      //System.ComponentModel.TypeListConverter;
      //System.ComponentModel.UInt32Converter;
      //System.ComponentModel.VersionConverter;

      // https://stackoverflow.com/questions/18608208/convert-single-xelement-to-object


      //ProductAttribute productAttribute = new ProductAttribute();
      //XElement xElement = XElement.Parse(
      //"<row flag='1' sect='3' header='4444' body='3434' extrainfo='0' />");

      ////StringReader reader = new StringReader(
      ////"<row flag='1' sect='3' header='4444' body='3434' extrainfo='0' />");

      //StringReader reader = new StringReader(xElement.ToString());
      //XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductAttribute));
      //productAttribute = (ProductAttribute)xmlSerializer.Deserialize(reader);





      Type type = o.GetType();

      PropertyInfo[] properties = type.GetProperties();

      foreach (PropertyInfo pi in properties) {
        if (pi.CustomAttributes != null) {
          if (pi.CustomAttributes.Count() > 0) {

            // TODO: Better do not filter. Iterate through them and sort them according to their Order arg, then check the name of each Attribute.
            // Based on the name a new XElement will be created ot if the name is XmlArray / xmlArrayItem then it needs more to be done.
            CustomAttributeData customAttribute = pi.CustomAttributes.Where(x => x.AttributeType.Name == "XmlElement").FirstOrDefault();
            
            if (customAttribute != null) {
              List<CustomAttributeTypedArgument> attrArgs = customAttribute.ConstructorArguments.ToList();
              if (attrArgs != null) {
                if (attrArgs.Count > 0) {
                  
                }
              }

              //string elementName = customAttribute.ConstructorArguments[0].Value.ToString();
              //object value = pi.GetValue(o);
              //if (value != null) {
              //  XElement xElement = new XElement(elementName, value);
              //  return xElement;
              //}

            }
          }
        }
      }


      System.ComponentModel.PropertyDescriptorCollection pdc = System.ComponentModel.TypeDescriptor.GetProperties(type);
      if (pdc != null) {
        if (pdc.Count > 0) {
          foreach (System.ComponentModel.PropertyDescriptor pd in pdc) {
            //pd.Attributes;
          }
        }
      }


      





      //CI_Address address = (CI_Address)o;

      //string gmdNS = "http://www.isotc211.org/2005/gmd";
      //string gcoNS = "http://www.isotc211.org/2005/gco";

      //XAttribute gmdXAttribute = new XAttribute(XNamespace.Xmlns + "gmd", gmdNS);
      //XAttribute gcoXAttribute = new XAttribute(XNamespace.Xmlns + "gco", gcoNS);

      //XName characterStringXName = XName.Get("CharacterString", gcoNS);

      //XName addressXName = XName.Get("CI_Address", gmdNS);

      //XName deliveryPointXName = XName.Get("deliveryPoint", gmdNS);
      //XName cityXName = XName.Get("city", gmdNS);
      //XName administrativeAreaXName = XName.Get("administrativeArea", gmdNS);
      //XName postalCodeXName = XName.Get("postalCode", gmdNS);
      //XName countryXName = XName.Get("country", gmdNS);
      //XName electronicMailAddressXName = XName.Get("electronicMailAddress", gmdNS);

      //XElement xAddress = new XElement(addressXName, gmdXAttribute,
      //  new XElement(deliveryPointXName,
      //    new XElement(characterStringXName, gcoXAttribute, address.DeliveryPoint)
      //  ),
      //  new XElement(cityXName,
      //    new XElement(characterStringXName, gcoXAttribute, address.City)
      //  ),
      //  new XElement(administrativeAreaXName,
      //    new XElement(characterStringXName, gcoXAttribute, address.AdministrativeArea)
      //  ),
      //  new XElement(postalCodeXName,
      //    new XElement(characterStringXName, gcoXAttribute, address.PostalCode)
      //  ),
      //  new XElement(countryXName,
      //    new XElement(characterStringXName, gcoXAttribute, address.Country)
      //  ),
      //  new XElement(electronicMailAddressXName,
      //    new XElement(characterStringXName, gcoXAttribute, address.ElectronicMailAddress)
      //  )
      //);

      //return xAddress;

      return null;

    }


    #endregion

  }

}
