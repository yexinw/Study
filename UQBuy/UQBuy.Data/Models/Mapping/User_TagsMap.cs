using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class User_TagsMap : EntityTypeConfiguration<User_Tags>
    {
        public User_TagsMap()
        {
            // Primary Key
            this.HasKey(t => t.UT_ID);

            // Properties
            this.Property(t => t.UT_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.UT_Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("User_Tags");
            this.Property(t => t.UT_ID).HasColumnName("UT_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.UT_Name).HasColumnName("UT_Name");
            this.Property(t => t.UT_CreateDate).HasColumnName("UT_CreateDate");
            this.Property(t => t.UT_State).HasColumnName("UT_State");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.User_Tags)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
