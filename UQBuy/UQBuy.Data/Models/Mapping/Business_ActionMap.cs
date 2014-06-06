using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Business_ActionMap : EntityTypeConfiguration<Business_Action>
    {
        public Business_ActionMap()
        {
            // Primary Key
            this.HasKey(t => t.BA_ID);

            // Properties
            this.Property(t => t.BA_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.B_ID)
                .HasMaxLength(36);

            this.Property(t => t.BA_Mark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Business_Action");
            this.Property(t => t.BA_ID).HasColumnName("BA_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.B_ID).HasColumnName("B_ID");
            this.Property(t => t.BA_Type).HasColumnName("BA_Type");
            this.Property(t => t.BA_CreateDate).HasColumnName("BA_CreateDate");
            this.Property(t => t.BA_Mark).HasColumnName("BA_Mark");

            // Relationships
            this.HasOptional(t => t.Business)
                .WithMany(t => t.Business_Action)
                .HasForeignKey(d => d.B_ID);
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Business_Action)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
