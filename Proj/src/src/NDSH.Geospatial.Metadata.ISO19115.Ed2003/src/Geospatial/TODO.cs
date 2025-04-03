
using NDSH.Xml.XLink;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NDSH.Geospatial {

  internal class TODO {

    // TODO: GLOBAL: > /Imagery has log files with inheritance problems. These need to be corrected

    // TODO: GLOBAL: > Remove ObservableModel references to Entities !!!
    // TODO: GLOBAL: > Deal with all the _PropertyType that point to Enums. // WARNING: Enum
    // TODO: GLOBAL: > Deal with all the _PropertyType that are exceptions to the rule
    // TODO: GLOBAL: > Deal with SpatialSchema folder that is exception to the rule
    // TODO: GLOBAL: > Check all source files with TASK comment: // WARNING: ASAP
    // TODO: GLOBAL: > Change all List<T> to ObservableCollection<T>

    // TODO: GLOBAL: > Inherit from CodeListValue_Type:
    //                   /Imagery/Acquisition
    //                   /Imagery/Content
    //                   /Imagery/DataQuality
    //                   /Localisation


    // TODO: GLOBAL: 1. Find all NillReasons and insert them in their Table
    // TODO: GLOBAL: 2. Check all properties of IObjectReference !!! Which ones of them need to be declared as nullable?
    // TODO: GLOBAL: 3. Remove ObjectReference_PropertyType in the source code.It remains to a lot of places that should not be there.
    // TODO: GLOBAL: 4. Remove AbstractObject_Type in the source code.It remains to a lot of places that should not be there.


    // TOOD: /XmlSchema/Catalogues/CRS/* - All these classes need to be reworked from _PropertyType to _Type and to inherit from their abstract wrapped classes.

    // TODO: LocalisedCharacterString_Type
    // TODO:   LocalisedCharacterString_PropertyType


    // TODO: GLOBAL: Read from the from the codelists.
    // C:\NDSH\GitHub\ndsh-dotnet-temp\dev\Proj\src\src\NDSH.Geospatial.Metadata.ISO19115.Ed2003\src\Geospatial\Schemas\ISO\2005\resources\Codelist\gmiCodelists.xml
    // C:\NDSH\GitHub\ndsh-dotnet-temp\dev\Proj\src\src\NDSH.Geospatial.Metadata.ISO19115.Ed2003\src\Geospatial\Schemas\ISO\2005\resources\Codelist\gmxCodelists.xml
    // C:\NDSH\GitHub\ndsh-dotnet-temp\dev\Proj\src\src\NDSH.Geospatial.Metadata.ISO19115.Ed2003\src\Geospatial\Schemas\ISO\2005\resources\crs\gmxCrs.xml
    // C:\NDSH\GitHub\ndsh-dotnet-temp\dev\Proj\src\src\NDSH.Geospatial.Metadata.ISO19115.Ed2003\src\Geospatial\Schemas\ISO\2005\resources\uom\gmxUom.xml

    // TODO: GLOBAL: - [Serializable] // Should this be used or should we drop it since the default .NET serializer can't serialize correctly?
    // What if we create our own serializer subclassing the .NET serializer? Will this need the attribute to be present?

    // TODO: GLOBAL: - AbstractCRSType - It must be deleted from NDSH.Geospatial.Metadata.V2003
    // TODO: GLOBAL: - CoordinateOperationAccuracy - 

    // TODO: GLOBAL: - SC_CRS_PropertyType - It must be deleted from NDSH.Geospatial.Metadata.V2003

    // TODO: GLOBAL: - What about the required modifier? Can it be used instead of the RequiredAttribute ???

    // TODO: Add Uri validation.
    //if (!Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute)) {
    //  throw new UriFormatException($"The provided '{nameof(CodeSpace)}' value is not a valid URI."); // RESOURCE
    //}

    // TODO: [Obsolete] attributes may need a special mention in the <remarks> (preferably) or <summary> section of the class, interface, enum documentation. Please add update them accordingly.

    // The [JsonProperty()] can use the following argument to avoid the property be included in a JSON serialized document.
    // NullValueHandling = NullValueHandling.Ignore
    // However this may be set to NullValueHandling = NullValueHandling.Required when the XML element or attribute is Required !!!

    // Use 'required' keyword, [RequiredAttribute], [JsonRequired] whenever a property is required. Make sure which of these options to use.

    // The fluent API should support the order that XmlElements and XmlAttributes are serialized. In cases that properties are inherited we need to pay attention they are serialized in the proper order.


    // ********************************************************************************
    // It seems that Metadata properties whose types inherit from AbstractObject_Type are decorated with an ObjectReference, but when a Metadata property is of type ObjectReference, then it is decorated by an NileReason
    // ********************************************************************************

    // ====================================================================================================
    //
    // *** *** /Geospatial/Metadata/ConceptualSchema needs to be moved to /Geospatial/ConceptualSchema *** ***
    //
    // ====================================================================================================

    // TODO: Properties should have decorations of type NilReasonEntity, ReferencedObject, Association

    // WARNING: Several types are substituted by others when it comes to serialization. It is not clear if the inheritance path allows massive substitutions, or only those mentioned by SubstitutionGroup.

    // SubstitutionGroup is more important than inheritance when it comes to how to create XML documents. We need a general way to deal with substitutions.

    // ********************************************************************************
    // 
    // The following is a validator in a setter. Have a look to find out those Validators.
    // 
    //  if (_coordOperation == null || _coordOperation.Equals(value) != true) {
    //    ValidationContext validatorPropContext = new ValidationContext(this, null, null);
    //    validatorPropContext.MemberName = "CoordOperation";
    //    Validator.ValidateProperty(value, validatorPropContext);
    //    _coordOperation = value;
    //    OnPropertyChanged("CoordOperation");
    //  }
    //
    // ********************************************************************************

    // Add deprecation XML doc for all [obsolete()] classes / properties / methods




    /*
     * 
     * VerticalCSType
     * VerticalCSPropertyType
     * VerticalCRSType
     * VerticalCRSPropertyType
     * TM_Primitive_PropertyType
     * EX_VerticalExtent_Type
     * EX_TemporalExtent_Type
     * 
     */

    /*
     * 
     * CRSPropertyType
     * AbstractCRSType
     * TODO
     * Mappings.txt
     * IdentifiableObject
     * AbstractGeometryType
     * AbstractGMLType
     * --------
     * MD_LegalConstraints_Type
     * MD_RepresentativeFraction_Type
     * UnitDefinitionType
     * UnitOfMeasure_PropertyType
     * MeasureType
     * Measure_PropertyType
     * LengthType
     * Length_PropertyType
     * Distance_PropertyType
     * MD_Resolution_Type
     * MD_Resolution_PropertyType
     * MD_Identifier_Type
     * EX_Extent_Type
     * ISrsReference
     * VerticalCSType
     * VerticalCSPropertyType
     * VerticalCRSType
     * VerticalCRSPropertyType
     * Association
     * GM_Point_PropertyType
     * GM_Object_PropertyType
     * EX_BoundingPolygon_Type
     *
     */

    /*
     * 
     * /ConceptualSchema/Derived/UnitsOfMeasure/Length_PropertyType.cs
     * /ConceptualSchema/Derived/UnitsOfMeasure/Measure_PropertyType.cs
     * /ConceptualSchema/Derived/UnitsOfMeasure/UnitOfMeasure_PropertyType.cs
     * /Identification/MD_Resolution_PropertyType.cs
     * /Identification/MD_Resolution_Type.cs
     * /Localisation/LocalisedCharacterString_PropertyType.cs
     * /Localisation/LocalisedCharacterString_Type.cs
     * 
     */

    /*
     * 
     * GF_PropertyType
     * GF_FeatureType
     * GF_AttributeType
     * 
     */

    /*
     * 
     * CRSPropertyType
     * AbstractCRSType
     * IdentifiedObjectType
     * CodeListDictionary_Type
     * DictionaryType
     * DefinitionType
     * DefinitionBaseType
     * AbstractGMLType
     * UnitDefinitionType
     * AbstractDatumType
     * 
     * CT_CodelistCatalogue_Type
     * 
     * MD_DigitalTransferOptions_Type
     * EX_TemporalExtent_Type
     * MD_SpatialRepresentationTypeCode_CodeList
     * DQ_Scope_PropertyType
     * TM_PeriodDuration_PropertyType
     * TM_Primitive_PropertyType
     * ML_CodeDefinition_Type
     * ClAlternativeExpression_Type
     *  
     */

    // attribute_frequency_report.xlsx
    // element_frequency_report.xlsx

    // GenericMetaDataType
    // InlinePropertyType
    // MetaDataPropertyType
    // NilReasonRemoteSchemaEntity

    // UomAngle_PropertyType and others similar to this have been deleted and now they need to be restored back to the project from V2003.

    /*
     * 
     * REVISIT
     * 
     * 

        /Geospatial/Gml/BasicTypes/
            Boolean
            CodeType
            MeasureListType

        /Geospatial/Gml/Coordinate/ReferenceSystems
            VerticalCRSPropertyType
            VerticalCRSType

        /Geospatial/Gml/Coordinate/Systems
            VerticalCSPropertyType
            VerticalCSType

        /Geospatial/Gml/Geometry/Basic0D1D
            AbstractGeometryType
            ISrsReference

        /Geospatial/Gml/Units
            UnitDefinitionType

        /Geospatial/Gml/ValueObjects
            BooleanPropertyType



        /Geospatial/Metadata/Common/Extent
            EX_VerticalExtent_Type

        /Geospatial/Metadata/ReferenceSystem
            SC_CRS_PropertyType

    *
    *
    */



    public void Collections() {

      //System.Collections.ArrayList;
      //System.Collections.CollectionBase;
      //System.Collections.DictionaryBase;
      //System.Collections.Hashtable;
      //System.Collections.ICollection;
      //System.Collections.IEnumerable;
      //System.Collections.IList;
      //System.Collections.ReadOnlyCollectionBase;
      //System.Collections.SortedList;

      //System.Collections.Generic.CollectionExtensions;
      //System.Collections.Generic.HashSet<T>;
      //System.Collections.Generic.ICollection<T>;
      //System.Collections.Generic.IEnumerable<T>;
      //System.Collections.Generic.IList<T>;
      //System.Collections.Generic.IReadOnlyCollection<T>;
      //System.Collections.Generic.IReadOnlyList<T>;
      //System.Collections.Generic.IReadOnlySet<T>;
      //System.Collections.Generic.ISet<T>;
      //System.Collections.Generic.List<T>;
      //System.Collections.Generic.SortedList<TKey, TValue>;
      //System.Collections.Generic.SortedSet<T>;

      //System.Collections.Immutable.IImmutableList<T>;
      //System.Collections.Immutable.IImmutableSet<T>;
      //System.Collections.Immutable.ImmutableHashSet;
      //System.Collections.Immutable.ImmutableHashSet<T>;
      //System.Collections.Immutable.ImmutableList;
      //System.Collections.Immutable.ImmutableList<T>;
      //System.Collections.Immutable.ImmutableSortedSet;
      //System.Collections.Immutable.ImmutableSortedSet<T>;

      //System.Collections.ObjectModel.Collection<T>;
      //System.Collections.ObjectModel.ObservableCollection<T>;
      //System.Collections.ObjectModel.ReadOnlyCollection<T>;
      //System.Collections.ObjectModel.ReadOnlyObservableCollection<T>;
      //System.Collections.ObjectModel.ReadOnlySet<T>;

      //System.Collections.Specialized.INotifyCollectionChanged;

    }




  }

}
