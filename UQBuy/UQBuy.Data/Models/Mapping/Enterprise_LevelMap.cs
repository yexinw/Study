using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Enterprise_LevelMap : EntityTypeConfiguration<Enterprise_Level>
    {
        public Enterprise_LevelMap()
        {
            // Primary Key
            this.HasKey(t => t.EL_ID);

            // Properties
            this.Property(t => t.EL_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.EL_Name)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Enterprise_Level");
            this.Property(t => t.EL_ID).HasColumnName("EL_ID");
            this.Property(t => t.EL_Name).HasColumnName("EL_Name");
            this.Property(t => t.EL_Value).HasColumnName("EL_Value");
        }
    }
}
