using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Service.Metadata;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Service.Metadata {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="SV_ServiceIdentification_Type" />.
  /// </summary>
  public sealed class SvServiceIdentificationConfiguration : IEntityTypeConfiguration<SV_ServiceIdentification_Type> {
    private const string TableName = "SV_ServiceIdentification";
    private const string ServiceTypeVersionTableName = "SV_ServiceIdentification_ServiceTypeVersion";
    private const string RestrictionsTableName = "SV_ServiceIdentification_Restrictions";
    private const string KeywordsTableName = "SV_ServiceIdentification_Keywords";
    private const string ExtentTableName = "SV_ServiceIdentification_Extent";
    private const string CoupledResourceTableName = "SV_ServiceIdentification_CoupledResource";
    private const string ContainsOperationsTableName = "SV_ServiceIdentification_ContainsOperations";
    private const string OperatesOnTableName = "SV_ServiceIdentification_OperatesOn";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<SV_ServiceIdentification_Type> builder) {
      builder.ToTable(TableName);

      builder.Ignore(entity => entity.AccessProperties);

      builder.HasOne(entity => entity.ServiceType)
        .WithMany()
        .HasForeignKey("ServiceType_CodeDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.ServiceTypeVersion)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ServiceTypeVersionTableName));

      builder.HasMany(entity => entity.Restrictions)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(RestrictionsTableName));

      builder.HasMany(entity => entity.Keywords)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(KeywordsTableName));

      builder.HasMany(entity => entity.Extent)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ExtentTableName));

      builder.HasOne(entity => entity.CouplingType)
        .WithMany()
        .HasForeignKey("CouplingType_CodeListDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.CoupledResource)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(CoupledResourceTableName));

      builder.HasMany(entity => entity.ContainsOperations)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ContainsOperationsTableName));

      builder.HasMany(entity => entity.OperatesOn)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(OperatesOnTableName));
    }
  }
}
