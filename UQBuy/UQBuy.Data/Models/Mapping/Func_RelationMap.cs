using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Func_RelationMap : EntityTypeConfiguration<Func_Relation>
    {
        public Func_RelationMap()
        {
            // Primary Key
            this.HasKey(t => t.FR_ID);

            // Properties
            this.Property(t => t.FR_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.UR_ID)
                .HasMaxLength(36);

            this.Property(t => t.RF_ID)
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("Func_Relation");
            this.Property(t => t.FR_ID).HasColumnName("FR_ID");
            this.Property(t => t.UR_ID).HasColumnName("UR_ID");
            this.Property(t => t.RF_ID).HasColumnName("RF_ID");

            // Relationships
            this.HasOptional(t => t.Role_Function)
                .WithMany(t => t.Func_Relation)
                .HasForeignKey(d => d.RF_ID);
            this.HasOptional(t => t.User_Role)
                .WithMany(t => t.Func_Relation)
                .HasForeignKey(d => d.UR_ID);

        }
    }
}
