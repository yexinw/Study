using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Enterprise_Level_RelationMap : EntityTypeConfiguration<Enterprise_Level_Relation>
    {
        public Enterprise_Level_RelationMap()
        {
            // Primary Key
            this.HasKey(t => t.ESLR_ID);

            // Properties
            this.Property(t => t.ESLR_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.EL_ID)
                .HasMaxLength(36);

            this.Property(t => t.ES_ID)
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("Enterprise_Level_Relation");
            this.Property(t => t.ESLR_ID).HasColumnName("ESLR_ID");
            this.Property(t => t.EL_ID).HasColumnName("EL_ID");
            this.Property(t => t.ES_ID).HasColumnName("ES_ID");
            this.Property(t => t.ESLR_TimeLimit).HasColumnName("ESLR_TimeLimit");
            this.Property(t => t.ESLR_Count).HasColumnName("ESLR_Count");

            // Relationships
            this.HasOptional(t => t.Enterprise_Level)
                .WithMany(t => t.Enterprise_Level_Relation)
                .HasForeignKey(d => d.EL_ID);
            this.HasOptional(t => t.Enterprise_Services)
                .WithMany(t => t.Enterprise_Level_Relation)
                .HasForeignKey(d => d.ES_ID);

        }
    }
}
