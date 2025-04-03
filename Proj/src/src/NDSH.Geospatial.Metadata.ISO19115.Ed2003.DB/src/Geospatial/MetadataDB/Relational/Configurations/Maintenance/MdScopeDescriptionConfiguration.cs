using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Maintenance;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Maintenance {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_ScopeDescription_Type" />.
  /// </summary>
  public sealed class MdScopeDescriptionConfiguration : IEntityTypeConfiguration<MD_ScopeDescription_Type> {
    private const string TableName = "MD_ScopeDescription";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_ScopeDescription_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyDbIdConfiguration();

      builder.HasDiscriminator<string>("ScopeDescriptionType")
        .HasValue<AttributeInstancesScopeDescription>("AttributeInstances")
        .HasValue<AttributesScopeDescription>("Attributes")
        .HasValue<DatasetScopeDescription>("DataSet")
        .HasValue<FeatureInstancesScopeDescription>("FeatureInstances")
        .HasValue<FeaturesScopeDescription>("Features")
        .HasValue<OtherScopeDescription>("Other");
    }
  }
}
