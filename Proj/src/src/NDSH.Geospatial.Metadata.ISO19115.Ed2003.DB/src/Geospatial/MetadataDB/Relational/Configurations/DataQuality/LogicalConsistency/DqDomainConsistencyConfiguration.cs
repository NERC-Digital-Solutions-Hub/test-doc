//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using NDSH.Geospatial.Metadata.DataQuality.LogicalConsistency;

//namespace NDSH.Geospatial.Metadata.DB.Configurations.Metadata.DataQuality
//{
//    /// <summary>
//    /// The <see cref="IEntityTypeConfiguration{TEntity}"/> for the <see cref="DQ_DomainConsistency_Type"/>.
//    /// </summary>
//    public sealed class DqDomainConsistencyConfiguration : IEntityTypeConfiguration<DQ_DomainConsistency_Type>
//    {
//        private const string TableName = "DQ_DomainConsistency";

//        /// <inheritdoc />
//        public void Configure(EntityTypeBuilder<DQ_DomainConsistency_Type> builder)
//        {
//            builder.ToTable(TableName);
//            //builder.HasBaseType((Type)null!);
//            //builder.HasKey(consistency => consistency.DbId);
//            //builder.Property(consistency => consistency.DbId)
//            //    .HasColumnName("DbId")
//            //    .ValueGeneratedOnAdd();

//            builder.Ignore(consistency => consistency.Id);
//            builder.Ignore(consistency => consistency.Uuid);
//            builder.Ignore(consistency => consistency.PropertyAttributes);
//            builder.Ignore(consistency => consistency.ReferencedObjects);

//        }
//    }
//}



