using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class BusinessMap : EntityTypeConfiguration<Business>
    {
        public BusinessMap()
        {
            // Primary Key
            this.HasKey(t => t.B_ID);

            // Properties
            this.Property(t => t.B_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.E_ID)
                .HasMaxLength(36);

            this.Property(t => t.B_Code)
                .HasMaxLength(20);

            this.Property(t => t.B_Name)
                .HasMaxLength(500);

            this.Property(t => t.B_Des)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Business");
            this.Property(t => t.B_ID).HasColumnName("B_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.E_ID).HasColumnName("E_ID");
            this.Property(t => t.B_Code).HasColumnName("B_Code");
            this.Property(t => t.B_Name).HasColumnName("B_Name");
            this.Property(t => t.B_Type).HasColumnName("B_Type");
            this.Property(t => t.B_Des).HasColumnName("B_Des");
            this.Property(t => t.B_CreateDate).HasColumnName("B_CreateDate");
            this.Property(t => t.B_EffectiveTime).HasColumnName("B_EffectiveTime");
            this.Property(t => t.B_EffectiveStatus).HasColumnName("B_EffectiveStatus");
            this.Property(t => t.B_EndDate).HasColumnName("B_EndDate");
            this.Property(t => t.B_State).HasColumnName("B_State");

            // Relationships
            this.HasOptional(t => t.Enterprise)
                .WithMany(t => t.Businesses)
                .HasForeignKey(d => d.E_ID);
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Businesses)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
