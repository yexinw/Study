using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Site_MessageMap : EntityTypeConfiguration<Site_Message>
    {
        public Site_MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.SM_ID);

            // Properties
            this.Property(t => t.SM_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.From_U_ID)
                .HasMaxLength(36);

            this.Property(t => t.To_U_ID)
                .HasMaxLength(36);

            this.Property(t => t.SM_Messae)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Site_Message");
            this.Property(t => t.SM_ID).HasColumnName("SM_ID");
            this.Property(t => t.From_U_ID).HasColumnName("From_U_ID");
            this.Property(t => t.To_U_ID).HasColumnName("To_U_ID");
            this.Property(t => t.SM_Messae).HasColumnName("SM_Messae");
            this.Property(t => t.SM_CreateDate).HasColumnName("SM_CreateDate");
            this.Property(t => t.SM_Type).HasColumnName("SM_Type");
            this.Property(t => t.SM_Status).HasColumnName("SM_Status");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Site_Message)
                .HasForeignKey(d => d.From_U_ID);
            this.HasOptional(t => t.Userbasic1)
                .WithMany(t => t.Site_Message1)
                .HasForeignKey(d => d.To_U_ID);

        }
    }
}
