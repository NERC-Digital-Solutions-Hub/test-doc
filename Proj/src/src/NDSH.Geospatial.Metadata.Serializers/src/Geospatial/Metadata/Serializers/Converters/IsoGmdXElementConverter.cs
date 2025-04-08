
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

#endregion

namespace NDSH.Geospatial.Metadata.Serializers.Converters {



  /// <summary>
  /// 
  /// </summary>
  public static class IsoGmdXElementConverter {

    /// <summary>
    /// 
    /// </summary>
    static IsoGmdXElementConverter() {

      //Type t = typeof(IsoGmdXElementConverter);
      //t.Assembly.GetReferencedAssemblies();
      

    }

    private static Dictionary<string, Type> _dict = new() {
      {"CI_ResponsibleParty",  typeof(CI_ResponsibleParty)},
      {"Entity",  typeof(Entity)},
      {"CI_Contact", typeof(CI_Contact) },
      {"CI_Telephone", typeof(CI_Telephone) },
      {"CI_Address", typeof(CI_Address) },

    };

    private static object Instatiate(string type) {
      bool isFound = _dict.TryGetValue(type, out var returnType);
      return (isFound && returnType != null) ? Activator.CreateInstance(returnType) : null;
    }

    /// <summary>
    /// This method converts an object to an XElement.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static System.Xml.Linq.XElement ToXElement(object obj) {

      // Create an XElement and add the type name as an attribute.
      System.Xml.Linq.XElement xElement = new System.Xml.Linq.XElement("Object");

      xElement.Add(new System.Xml.Linq.XAttribute("type", obj.GetType().Name));

      // Get the properties for the object.
      System.Reflection.PropertyInfo[] properties = obj.GetType().GetProperties();

      // Add an XElement for each property.
      foreach (System.Reflection.PropertyInfo property in properties) {
        xElement.Add(new System.Xml.Linq.XElement(property.Name, property.GetValue(obj)));
      }
      return xElement;
    }

    /// <summary>
    /// Create a method that converts an XElement to an object using reflection.
    /// </summary>
    /// <param name="xElement"></param>
    /// <returns></returns>
    public static object? ToObject(System.Xml.Linq.XElement xElement) {

      // Get the type name from the attribute.
      string typeName = xElement.Name?.LocalName;
      if (typeName == null) {
        Debug.Print("typeName is null.");
        return null;
      }


      object obj = Instatiate(typeName);
      Debug.Assert(obj != null);
      //get all the xElement nodes
      if (xElement.HasElements) {
        List<XNode> nodes = xElement.Nodes().Where(n => n.NodeType == System.Xml.XmlNodeType.Element).ToList();
        // get all properties of the obj
        PropertyInfo[] properties = obj.GetType().GetProperties();

        if (nodes != null) {
          if (nodes.Count > 0) {
            foreach (XNode node in nodes) {
              XElement propertyElement = node as XElement;
              if (propertyElement != null) {
                string xProp = propertyElement.Name.LocalName.ToLower(CultureInfo.InvariantCulture);

                List<PropertyInfo> matchedProperties = properties.Where(p => p.Name.ToLower(CultureInfo.InvariantCulture) == xProp).ToList();
                if (matchedProperties != null) {
                  if (matchedProperties.Count == 1) {
                    PropertyInfo matchedProperty = matchedProperties[0];

                    List<XNode> xPropValueNodes = propertyElement.Nodes().Where(n => n.NodeType == System.Xml.XmlNodeType.Element).ToList();

                    if (xPropValueNodes != null) {
                      if (xPropValueNodes.Count == 1) {
                        XElement xElementPropValue = xPropValueNodes[0] as XElement;
                        string xElementPropValueName = xElementPropValue.Name.LocalName;
                        bool isFound = _dict.TryGetValue(xElementPropValueName, out Type t);
                        if (isFound) {
                          object obj2 = ToObject(xElementPropValue);
                          matchedProperty.SetValue(obj, obj2);
                        }
                        else {
                          if (xElementPropValueName == "CharacterString") {
                            if (xElementPropValue.Nodes() != null) {
                              if (xElementPropValue.Nodes().Count() == 1) {
                                XNode xStringNode = xElementPropValue.Nodes().ToList().First();
                                if (xStringNode.NodeType == System.Xml.XmlNodeType.Text) {
                                  XText xString = xElementPropValue.Nodes().ToList().First() as XText;
                                  matchedProperty.SetValue(obj, (object)xString.Value);

                                }
                                else {
                                  Debug.Assert(false);

                                }

                              }
                              else {

                              }
                            }
                          }
                        }



                      }
                      else {
                        // Error condition
                      }
                    }


                  }
                  else {
                    // DO SOMETHING HERE
                  }
                }

              }


            }
          }
        }
      }

      return obj;
    }





    public static object? ToObjectChris(System.Xml.Linq.XElement xRoot) {
      if (xRoot == null || xRoot.Name == null)
        return null;

      object rootObj = Instatiate(xRoot.Name.LocalName);
      if (rootObj == null) {
        throw new Exception($"root Obj is null. please add {xRoot.Name.LocalName} class to dictionary!");
      }
      List<PropertyInfo> props = rootObj.GetType().GetProperties().ToList();
      List<XElement> xProps = xRoot.Nodes().Cast<XElement>().ToList();

      foreach (PropertyInfo prop in props) {

        XElement? xProp = xProps.Where(xp => xp.Name.LocalName.ToLowerInvariant() == prop.Name.ToLowerInvariant()).FirstOrDefault();
        if (xProp is null)
          continue;

        object xPropValue = null;

        if (xProp.NodeType == XmlNodeType.Element) {
          if (xProp.FirstNode is not null && xProp.FirstNode.NodeType == XmlNodeType.Element) {
            XElement xPropContent = xProp.FirstNode as XElement;
            if (xPropContent.HasElements) {
              // prop is a class
              xPropValue = ToObjectChris(xPropContent);
            }
            else if (xPropContent.Name.LocalName == "CharacterString") {
              // is a elementary prop
              XText xt = xPropContent.FirstNode as XText;
              xPropValue = xt?.Value;
            }
            else {
              XText xt = xPropContent.FirstNode as XText;
              xPropValue = xt?.Value;
              //Debug.Assert(false, "You should not be here.");
              //CI_Role
            }
          }
        }

        // set propValue
        if (prop.PropertyType.Name == "List`1") { //list<string>
          object lsPropValue = Activator.CreateInstance(prop.PropertyType);
          ((List<string>)lsPropValue).Add((string)xPropValue);
          prop.SetValue(rootObj, lsPropValue); //string
        } else if (prop.PropertyType.Name == "CI_RoleCode") {
          var a = "Got you!";
          // TODO: Handle Enum prop??
          CI_RoleCode role = new();
          //role.Value = CI_RolexPropValue;
          //prop.SetValue(rootObj, r);
        }
        else {
          prop.SetValue(rootObj, xPropValue); //string
        
        }
      }
      return rootObj;

    }



  }
}
