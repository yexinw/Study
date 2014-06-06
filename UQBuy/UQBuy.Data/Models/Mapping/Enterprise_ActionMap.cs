using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Enterprise_ActionMap : EntityTypeConfiguration<Enterprise_Action>
    {
        public Enterprise_ActionMap()
        {
            // Primary Key
            this.HasKey(t => t.EA_ID);

            // Properties
            this.Property(t => t.EA_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.E_ID)
                .HasMaxLength(36);

            this.Property(t => t.EA_Mark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Enterprise_Action");
            this.Property(t => t.EA_ID).HasColumnName("EA_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.E_ID).HasColumnName("E_ID");
            this.Property(t => t.EA_Type).HasColumnName("EA_Type");
            this.Property(t => t.EA_CreateDate).HasColumnName("EA_CreateDate");
            this.Property(t => t.EA_Mark).HasColumnName("EA_Mark");

            // Relationships
            this.HasOptional(t => t.Enterprise)
                .WithMany(t => t.Enterprise_Action)
                .HasForeignKey(d => d.E_ID);
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Enterprise_Action)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
