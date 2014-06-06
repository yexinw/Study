using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Enterprise_Services_ActionMap : EntityTypeConfiguration<Enterprise_Services_Action>
    {
        public Enterprise_Services_ActionMap()
        {
            // Primary Key
            this.HasKey(t => t.USA_ID);

            // Properties
            this.Property(t => t.USA_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.ES_ID)
                .HasMaxLength(36);

            this.Property(t => t.E_ID)
                .HasMaxLength(36);

            this.Property(t => t.USA_Des)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Enterprise_Services_Action");
            this.Property(t => t.USA_ID).HasColumnName("USA_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.ES_ID).HasColumnName("ES_ID");
            this.Property(t => t.E_ID).HasColumnName("E_ID");
            this.Property(t => t.USA_EndDate).HasColumnName("USA_EndDate");
            this.Property(t => t.USA_CreateDate).HasColumnName("USA_CreateDate");
            this.Property(t => t.USA_Count).HasColumnName("USA_Count");
            this.Property(t => t.USA_Des).HasColumnName("USA_Des");

            // Relationships
            this.HasOptional(t => t.Enterprise)
                .WithMany(t => t.Enterprise_Services_Action)
                .HasForeignKey(d => d.E_ID);
            this.HasOptional(t => t.Enterprise_Services)
                .WithMany(t => t.Enterprise_Services_Action)
                .HasForeignKey(d => d.ES_ID);

        }
    }
}
