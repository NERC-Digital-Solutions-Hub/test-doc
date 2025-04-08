using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Service.Metadata;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Service.Metadata {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="SV_OperationMetadata_Type" />.
  /// </summary>
  public sealed class SvOperationMetadataConfiguration : IEntityTypeConfiguration<SV_OperationMetadata_Type> {
    private const string TableName = "SV_OperationMetadata";
    private const string DcpTableName = "SV_OperationMetadata_DCP";
    private const string ParametersTableName = "SV_OperationMetadata_Parameters";
    private const string ConnectPointTableName = "SV_OperationMetadata_ConnectPoint";
    private const string DependsOnTableName = "SV_OperationMetadata_DependsOn";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<SV_OperationMetadata_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.OperationName)
        .WithMany()
        .HasForeignKey("OperationName_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.DCP)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DcpTableName));

      builder.HasOne(entity => entity.OperationDescription)
        .WithMany()
        .HasForeignKey("OperationDescription_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.InvocationName)
        .WithMany()
        .HasForeignKey("InvocationName_CharacterStringDbId")
        .IsRequired(false);

      builder.Ignore(entity => entity.Parameters); // TODO: TEMP
      //builder.HasMany(entity => entity.Parameters)
      //    .WithMany()
      //    .UsingEntity(entity => entity.ToTable(ParametersTableName));

      builder.HasMany(entity => entity.ConnectPoint)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ConnectPointTableName));

      builder.HasMany(entity => entity.DependsOn)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DependsOnTableName));
    }
  }
}
