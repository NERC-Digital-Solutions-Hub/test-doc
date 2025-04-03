
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// History           : 06/03/2025, @gisvlasta - Renamed enum from MD_TopicCategoryCode_Type to MD_TopicCategoryCodes.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/identification.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="MD_TopicCategoryCode_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="farming"/>
//     <xs:enumeration value="biota"/>
//     <xs:enumeration value="boundaries"/>
//     <xs:enumeration value="climatologyMeteorologyAtmosphere"/>
//     <xs:enumeration value="economy"/>
//     <xs:enumeration value="elevation"/>
//     <xs:enumeration value="environment"/>
//     <xs:enumeration value="geoscientificInformation"/>
//     <xs:enumeration value="health"/>
//     <xs:enumeration value="imageryBaseMapsEarthCover"/>
//     <xs:enumeration value="intelligenceMilitary"/>
//     <xs:enumeration value="inlandWaters"/>
//     <xs:enumeration value="location"/>
//     <xs:enumeration value="oceans"/>
//     <xs:enumeration value="planningCadastre"/>
//     <xs:enumeration value="society"/>
//     <xs:enumeration value="structure"/>
//     <xs:enumeration value="transportation"/>
//     <xs:enumeration value="utilitiesCommunication"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="MD_TopicCategoryCode"
//             type="gmd:MD_TopicCategoryCode_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MD_TopicCategoryCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_TopicCategoryCode"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Identification {

  /// <summary>
  /// High-level geographic data thematic classification to assist in the grouping and
  /// search of available geographic data sets. Can be used to group keywords as well.
  /// Listed examples are not exhaustive.
  /// </summary>
  /// <remarks>
  /// It is understood there are overlaps between general categories and the user
  /// is encouraged to select the one most appropriate.
  /// </remarks>
  [Serializable]
  //[XmlType("MD_TopicCategoryCode", Namespace = "http://www.isotc211.org/2005/gmd")] // TODO: Should it be AnonymousType???
  //[XmlRoot("MD_TopicCategoryCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: XmlRoot here???
  public enum MD_TopicCategoryCodes {

    /// <summary>
    /// Rearing of animals and/or cultivation of plants.
    /// </summary>
    /// <example>
    /// agriculture, irrigation, aquaculture, plantations, herding,
    /// pests and diseases affecting crops and livestock.
    /// </example>
    //[XmlEnum(Name = "farming")]
    [EnumMember(Value = "farming")]
    Farming = 1,

    /// <summary>
    /// Flora and/or fauna in natural environment.
    /// </summary>
    /// <example>
    /// wildlife, vegetation, biological sciences, ecology, wilderness, sealife, wetlands, habitat.
    /// </example>
    //[XmlEnum(Name = "biota")]
    [EnumMember(Value = "biota")]
    Biota = 2,

    /// <summary>
    /// Legal land descriptions.
    /// </summary>
    /// <example>
    /// political and administrative boundaries.
    /// </example>
    //[XmlEnum(Name = "boundaries")]
    [EnumMember(Value = "boundaries")]
    Boundaries = 3,

    /// <summary>
    /// Processes and phenomena of the atmosphere.
    /// </summary>
    /// <example>
    /// cloud cover, weather, climate, atmospheric conditions, climate change, precipitation.
    /// </example>
    //[XmlEnum(Name = "climatologyMeteorologyAtmosphere")]
    [EnumMember(Value = "climatologyMeteorologyAtmosphere")]
    ClimatologyMeteorologyAtmosphere = 4,

    /// <summary>
    /// Economic activities, conditions and employment.
    /// </summary>
    /// <example>
    /// production, labour, revenue, commerce, industry, tourism and ecotourism, forestry, fisheries,
    /// commercial or subsistence hunting, exploration and exploitation of resources such as minerals, oil and gas.
    /// </example>
    //[XmlEnum(Name = "economy")]
    [EnumMember(Value = "economy")]
    Economy = 5,

    /// <summary>
    /// Height above or below sea level.
    /// </summary>
    /// <example>
    /// altitude, bathymetry, digital elevation models, slope, derived products.
    /// </example>
    //[XmlEnum(Name = "elevation")]
    [EnumMember(Value = "elevation")]
    Elevation = 6,

    /// <summary>
    /// Environmental resources, protection and conservation.
    /// </summary>
    /// <example>
    /// environmental pollution, waste storage and treatment, environmental impact assessment,
    /// monitoring environmental risk, nature reserves, landscape.
    /// </example>
    //[XmlEnum(Name = "environment")]
    [EnumMember(Value = "environment")]
    Environment = 7,

    /// <summary>
    /// Information pertaining to earth sciences.
    /// </summary>
    /// <example>
    /// geophysical features and processes, geology, minerals, sciences dealing with the composition,
    /// structure and origin of the earth’s rocks, risks of earthquakes, volcanic activity, landslides,
    /// gravity information, soils, permafrost, hydrogeology, erosion.
    /// </example>
    //[XmlEnum(Name = "geoscientificInformation")]
    [EnumMember(Value = "geoscientificInformation")]
    GeoscientificInformation = 8,

    /// <summary>
    /// Health, health services, human ecology, and safety.
    /// </summary>
    /// <example>
    /// disease and illness, factors affecting health, hygiene, substance abuse,
    /// mental and physical health, health services.
    /// </example>
    //[XmlEnum(Name = "health")]
    [EnumMember(Value = "health")]
    Health = 9,

    /// <summary>
    /// Base maps.
    /// </summary>
    /// <example>
    /// land cover, topographic maps, imagery, unclassified images, annotations.
    /// </example>
    //[XmlEnum(Name = "imageryBaseMapsEarthCover")]
    [EnumMember(Value = "imageryBaseMapsEarthCover")]
    ImageryBaseMapsEarthCover = 10,

    /// <summary>
    /// Military bases, structures, activities.
    /// </summary>
    /// <example>
    /// barracks, training grounds, military transportation, information collection.
    /// </example>
    //[XmlEnum(Name = "intelligenceMilitary")]
    [EnumMember(Value = "intelligenceMilitary")]
    IntelligenceMilitary = 11,

    /// <summary>
    /// Inland water features, drainage systems and their characteristics.
    /// </summary>
    /// <example>
    /// Rivers and glaciers, salt lakes, water utilization plans, dams, currents,
    /// floods, water quality, hydrographic charts.
    /// </example>
    //[XmlEnum(Name = "inlandWaters")]
    [EnumMember(Value = "inlandWaters")]
    InlandWaters = 12,

    /// <summary>
    /// Positional information and services.
    /// </summary>
    /// <example>
    /// addresses, geodetic networks, control points, postal zones and services, place names.
    /// </example>
    //[XmlEnum(Name = "location")]
    [EnumMember(Value = "location")]
    Location = 13,

    /// <summary>
    /// Features and characteristics of salt water bodies (excluding inland waters).
    /// </summary>
    /// <example>
    /// tides, tidal waves, coastal information, reefs.
    /// </example>
    //[XmlEnum(Name = "oceans")]
    [EnumMember(Value = "oceans")]
    Oceans = 14,

    /// <summary>
    /// Information used for appropriate actions for future use of the land.
    /// </summary>
    /// <example>
    /// land use maps, zoning maps, cadastral surveys, land ownership.
    /// </example>
    //[XmlEnum(Name = "planningCadastre")]
    [EnumMember(Value = "planningCadastre")]
    PlanningCadastre = 15,

    /// <summary>
    /// Characteristics of society and cultures.
    /// </summary>
    /// <example>
    /// settlements, anthropology, archaeology, education, traditional beliefs, manners and customs, demographic data,
    /// recreational areas and activities, social impact assessments, crime and justice, census information.
    /// </example>
    //[XmlEnum(Name = "society")]
    [EnumMember(Value = "society")]
    Society = 16,

    /// <summary>
    /// Man-made construction.
    /// </summary>
    /// <example>
    /// buildings, museums, churches, factories, housing, monuments, shops, towers.
    /// </example>
    //[XmlEnum(Name = "structure")]
    [EnumMember(Value = "structure")]
    Structure = 17,

    /// <summary>
    /// Means and aids for conveying persons and/or goods.
    /// </summary>
    /// <example>
    /// roads, airports/airstrips, shipping routes, tunnels, nautical charts,
    /// vehicle or vessel location, aeronautical charts, railways.
    /// </example>
    //[XmlEnum(Name = "transportation")]
    [EnumMember(Value = "transportation")]
    Transportation = 18,

    /// <summary>
    /// Energy, water and waste systems and communications infrastructure and services.
    /// </summary>
    /// <example>
    /// hydroelectricity, geothermal, solar and nuclear sources of energy, water purification and distribution,
    /// sewage collection and disposal, electricity and gas distribution, data communication, telecommunication,
    /// radio, communication networks.
    /// </example>
    //[XmlEnum(Name = "utilitiesCommunication")]
    [EnumMember(Value = "utilitiesCommunication")]
    UtilitiesCommunication = 19,

  }

}
