using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class EnterpriseMap : EntityTypeConfiguration<Enterprise>
    {
        public EnterpriseMap()
        {
            // Primary Key
            this.HasKey(t => t.E_ID);

            // Properties
            this.Property(t => t.E_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.TI_ID)
                .HasMaxLength(36);

            this.Property(t => t.BL_ID)
                .HasMaxLength(36);

            this.Property(t => t.E_Code)
                .HasMaxLength(20);

            this.Property(t => t.E_Name)
                .HasMaxLength(500);

            this.Property(t => t.E_MainWork)
                .HasMaxLength(1000);

            this.Property(t => t.E_Explain)
                .HasMaxLength(100);

            this.Property(t => t.E_Des)
                .HasMaxLength(4000);

            this.Property(t => t.E_VideoLink)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Enterprise");
            this.Property(t => t.E_ID).HasColumnName("E_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.TI_ID).HasColumnName("TI_ID");
            this.Property(t => t.BL_ID).HasColumnName("BL_ID");
            this.Property(t => t.E_Code).HasColumnName("E_Code");
            this.Property(t => t.E_Name).HasColumnName("E_Name");
            this.Property(t => t.E_MainWork).HasColumnName("E_MainWork");
            this.Property(t => t.E_Explain).HasColumnName("E_Explain");
            this.Property(t => t.E_Des).HasColumnName("E_Des");
            this.Property(t => t.E_VideoLink).HasColumnName("E_VideoLink");
            this.Property(t => t.E_Status).HasColumnName("E_Status");
            this.Property(t => t.E_CreateDate).HasColumnName("E_CreateDate");
            this.Property(t => t.E_State).HasColumnName("E_State");

            // Relationships
            this.HasOptional(t => t.Enterprise_Level)
                .WithMany(t => t.Enterprises)
                .HasForeignKey(d => d.BL_ID);
            this.HasOptional(t => t.Type_Industry)
                .WithMany(t => t.Enterprises)
                .HasForeignKey(d => d.TI_ID);
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Enterprises)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
