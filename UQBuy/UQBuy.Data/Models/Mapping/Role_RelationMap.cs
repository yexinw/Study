using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Role_RelationMap : EntityTypeConfiguration<Role_Relation>
    {
        public Role_RelationMap()
        {
            // Primary Key
            this.HasKey(t => t.RR_ID);

            // Properties
            this.Property(t => t.RR_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.UR_ID)
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("Role_Relation");
            this.Property(t => t.RR_ID).HasColumnName("RR_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.UR_ID).HasColumnName("UR_ID");

            // Relationships
            this.HasOptional(t => t.User_Role)
                .WithMany(t => t.Role_Relation)
                .HasForeignKey(d => d.UR_ID);
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Role_Relation)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
