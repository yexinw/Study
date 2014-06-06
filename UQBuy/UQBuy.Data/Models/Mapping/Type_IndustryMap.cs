using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Type_IndustryMap : EntityTypeConfiguration<Type_Industry>
    {
        public Type_IndustryMap()
        {
            // Primary Key
            this.HasKey(t => t.TI_ID);

            // Properties
            this.Property(t => t.TI_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.TI_PID)
                .HasMaxLength(36);

            this.Property(t => t.TI_Name)
                .HasMaxLength(200);

            this.Property(t => t.TI_Code)
                .HasMaxLength(20);

            this.Property(t => t.TI_Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Type_Industry");
            this.Property(t => t.TI_ID).HasColumnName("TI_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.TI_PID).HasColumnName("TI_PID");
            this.Property(t => t.TI_Name).HasColumnName("TI_Name");
            this.Property(t => t.TI_Code).HasColumnName("TI_Code");
            this.Property(t => t.TI_Level).HasColumnName("TI_Level");
            this.Property(t => t.TI_Remark).HasColumnName("TI_Remark");
            this.Property(t => t.TI_Sort).HasColumnName("TI_Sort");
            this.Property(t => t.TI_CreateDate).HasColumnName("TI_CreateDate");
            this.Property(t => t.TI_State).HasColumnName("TI_State");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Type_Industry)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
