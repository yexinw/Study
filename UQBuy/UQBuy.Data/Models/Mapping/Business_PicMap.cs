using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Business_PicMap : EntityTypeConfiguration<Business_Pic>
    {
        public Business_PicMap()
        {
            // Primary Key
            this.HasKey(t => t.BP_ID);

            // Properties
            this.Property(t => t.BP_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.B_ID)
                .HasMaxLength(36);

            this.Property(t => t.BP_Des)
                .HasMaxLength(1000);

            this.Property(t => t.BP_Path)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Business_Pic");
            this.Property(t => t.BP_ID).HasColumnName("BP_ID");
            this.Property(t => t.B_ID).HasColumnName("B_ID");
            this.Property(t => t.BP_Des).HasColumnName("BP_Des");
            this.Property(t => t.BP_Path).HasColumnName("BP_Path");
            this.Property(t => t.BP_Level).HasColumnName("BP_Level");

            // Relationships
            this.HasOptional(t => t.Business)
                .WithMany(t => t.Business_Pic)
                .HasForeignKey(d => d.B_ID);

        }
    }
}
