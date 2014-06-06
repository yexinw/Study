using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class User_RoleMap : EntityTypeConfiguration<User_Role>
    {
        public User_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UR_ID);

            // Properties
            this.Property(t => t.UR_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.UR_Name)
                .HasMaxLength(100);

            this.Property(t => t.UR_Code)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("User_Role");
            this.Property(t => t.UR_ID).HasColumnName("UR_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.UR_Name).HasColumnName("UR_Name");
            this.Property(t => t.UR_Code).HasColumnName("UR_Code");
            this.Property(t => t.UR_Type).HasColumnName("UR_Type");
            this.Property(t => t.UR_CreateDate).HasColumnName("UR_CreateDate");
            this.Property(t => t.UR_State).HasColumnName("UR_State");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.User_Role)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
