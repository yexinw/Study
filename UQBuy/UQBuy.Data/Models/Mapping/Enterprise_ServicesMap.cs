using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Enterprise_ServicesMap : EntityTypeConfiguration<Enterprise_Services>
    {
        public Enterprise_ServicesMap()
        {
            // Primary Key
            this.HasKey(t => t.ES_ID);

            // Properties
            this.Property(t => t.ES_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.ES_Name)
                .HasMaxLength(200);

            this.Property(t => t.ES_Des)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Enterprise_Services");
            this.Property(t => t.ES_ID).HasColumnName("ES_ID");
            this.Property(t => t.ES_Name).HasColumnName("ES_Name");
            this.Property(t => t.ES_Des).HasColumnName("ES_Des");
            this.Property(t => t.ES_CreateDate).HasColumnName("ES_CreateDate");
            this.Property(t => t.ES_State).HasColumnName("ES_State");
        }
    }
}
