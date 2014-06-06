using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class User_AuthenticationMap : EntityTypeConfiguration<User_Authentication>
    {
        public User_AuthenticationMap()
        {
            // Primary Key
            this.HasKey(t => t.UA_ID);

            // Properties
            this.Property(t => t.UA_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.UA_Content)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("User_Authentication");
            this.Property(t => t.UA_ID).HasColumnName("UA_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.UA_Type).HasColumnName("UA_Type");
            this.Property(t => t.UA_Content).HasColumnName("UA_Content");
            this.Property(t => t.UA_CreateDate).HasColumnName("UA_CreateDate");
            this.Property(t => t.UA_Satus).HasColumnName("UA_Satus");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.User_Authentication)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
