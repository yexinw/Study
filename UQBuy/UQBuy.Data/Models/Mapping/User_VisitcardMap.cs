using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class User_VisitcardMap : EntityTypeConfiguration<User_Visitcard>
    {
        public User_VisitcardMap()
        {
            // Primary Key
            this.HasKey(t => t.UV_ID);

            // Properties
            this.Property(t => t.UV_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.Member_U_ID)
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("User_Visitcard");
            this.Property(t => t.UV_ID).HasColumnName("UV_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.Member_U_ID).HasColumnName("Member_U_ID");
            this.Property(t => t.UV_Status).HasColumnName("UV_Status");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.User_Visitcard)
                .HasForeignKey(d => d.Member_U_ID);
            this.HasOptional(t => t.Userbasic1)
                .WithMany(t => t.User_Visitcard1)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
