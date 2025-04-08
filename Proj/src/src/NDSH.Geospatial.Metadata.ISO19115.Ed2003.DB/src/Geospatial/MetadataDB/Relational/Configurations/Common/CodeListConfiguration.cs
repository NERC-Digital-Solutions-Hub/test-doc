using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Constraint;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.Localisation;
using NDSH.Geospatial.Metadata.Maintenance;
using NDSH.Geospatial.Metadata.Service.Metadata;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CodeListValue_Type" />.
  /// </summary>
  public sealed class CodeListConfiguration : IEntityTypeConfiguration<CodeListValue_Type> {
    private const string TableName = "CodeList";
    private const string AdditionalInfoTableName = "CodeList_AdditionalInfo";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CodeListValue_Type> builder) {
      builder.ToTable(TableName);
      builder.HasBaseType((Type)null!);
      builder.ApplyDbIdConfiguration();

      builder.HasDiscriminator<string>("Discriminator")
        .HasValue<CI_DateTypeCode_CodeList>("CI_DateTypeCode")
        .HasValue<CI_OnLineFunctionCode_CodeList>("CI_OnLineFunctionCode")
        .HasValue<CI_RoleCode_CodeList>("CI_RoleCode")
        .HasValue<LanguageCode_CodeList>("LanguageCode")
        .HasValue<MD_CharacterSetCode_CodeList>("MD_CharacterSetCode")
        .HasValue<MD_KeywordTypeCode_CodeList>("MD_KeywordTypeCode")
        .HasValue<MD_SpatialRepresentationTypeCode_CodeList>("MD_SpatialRepresentationTypeCode")
        .HasValue<MD_RestrictionCode_CodeList>("MD_RestrictionCode")
        .HasValue<MD_KeywordTypeCode_CodeList>("MD_KeywordTypeCode")
        .HasValue<MD_SpatialRepresentationTypeCode_CodeList>("MD_SpatialRepresentationTypeCode")
        .HasValue<MD_MaintenanceFrequencyCode_CodeList>("MD_MaintenanceFrequencyCode")
        .HasValue<MD_ScopeCode_CodeList>("MD_ScopeCode")
        .HasValue<SV_CouplingType_CodeList>("SV_CouplingType");
    }
  }
}
