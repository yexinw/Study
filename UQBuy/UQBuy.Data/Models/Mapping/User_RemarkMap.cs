using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class User_RemarkMap : EntityTypeConfiguration<User_Remark>
    {
        public User_RemarkMap()
        {
            // Primary Key
            this.HasKey(t => t.UR_ID);

            // Properties
            this.Property(t => t.UR_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.UR_Title)
                .HasMaxLength(100);

            this.Property(t => t.UR_Content)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("User_Remark");
            this.Property(t => t.UR_ID).HasColumnName("UR_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.UR_Title).HasColumnName("UR_Title");
            this.Property(t => t.UR_Content).HasColumnName("UR_Content");
            this.Property(t => t.UR_StartDate).HasColumnName("UR_StartDate");
            this.Property(t => t.UR_EndDate).HasColumnName("UR_EndDate");
            this.Property(t => t.UR_CreateDate).HasColumnName("UR_CreateDate");
            this.Property(t => t.UR_Status).HasColumnName("UR_Status");
            this.Property(t => t.UR_State).HasColumnName("UR_State");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.User_Remark)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
