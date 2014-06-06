using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Tags_RelationMap : EntityTypeConfiguration<Tags_Relation>
    {
        public Tags_RelationMap()
        {
            // Primary Key
            this.HasKey(t => t.TR_ID);

            // Properties
            this.Property(t => t.TR_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.UT_ID)
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("Tags_Relation");
            this.Property(t => t.TR_ID).HasColumnName("TR_ID");
            this.Property(t => t.UT_ID).HasColumnName("UT_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.TR_Level).HasColumnName("TR_Level");

            // Relationships
            this.HasOptional(t => t.User_Tags)
                .WithMany(t => t.Tags_Relation)
                .HasForeignKey(d => d.UT_ID);
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Tags_Relation)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
