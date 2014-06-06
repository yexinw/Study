using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class User_IntegralMap : EntityTypeConfiguration<User_Integral>
    {
        public User_IntegralMap()
        {
            // Primary Key
            this.HasKey(t => t.UI_ID);

            // Properties
            this.Property(t => t.UI_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.UI_Des)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("User_Integral");
            this.Property(t => t.UI_ID).HasColumnName("UI_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.UI_Score).HasColumnName("UI_Score");
            this.Property(t => t.UI_Des).HasColumnName("UI_Des");
            this.Property(t => t.UI_CreateDate).HasColumnName("UI_CreateDate");
            this.Property(t => t.UI_State).HasColumnName("UI_State");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.User_Integral)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
