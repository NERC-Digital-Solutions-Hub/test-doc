//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using NDSH.Geospatial.Metadata.DataQuality;
//using NDSH.Geospatial.Metadata.DB.Configurations.Extensions;

//namespace NDSH.Geospatial.Metadata.DB.Configurations.Metadata.DataQuality {
//  /// <summary>
//  /// The <see cref="IEntityTypeConfiguration{TEntity}"/> for the <see cref="AbstractDQ_Element_Type"/>.
//  /// </summary>
//  public sealed class AbstractDqElementConfiguration : IEntityTypeConfiguration<AbstractDQ_Element_Type> {
//    private const string TableName = "AbstractDQ_Element";
//    private const string ResultTableName = "AbstractDQ_Element_Result";

//    /// <inheritdoc />
//    public void Configure(EntityTypeBuilder<AbstractDQ_Element_Type> builder) {
//      builder.ToTable(TableName);
//      builder.ApplyBaseConfiguration();

//      builder.Ignore(scope => scope.DateTime); // TODO:

//      builder.HasMany(entity => entity.Result)
//          .WithMany()
//          .UsingEntity(entity => entity.ToTable(ResultTableName));
//    }
//  }
//}



