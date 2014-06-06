using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Role_FunctionMap : EntityTypeConfiguration<Role_Function>
    {
        public Role_FunctionMap()
        {
            // Primary Key
            this.HasKey(t => t.RF_ID);

            // Properties
            this.Property(t => t.RF_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.RF_Name)
                .HasMaxLength(200);

            this.Property(t => t.RF_Des)
                .HasMaxLength(500);

            this.Property(t => t.RF_Remark)
                .HasMaxLength(100);

            this.Property(t => t.RF_BackFor)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Role_Function");
            this.Property(t => t.RF_ID).HasColumnName("RF_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.RF_Name).HasColumnName("RF_Name");
            this.Property(t => t.RF_Type).HasColumnName("RF_Type");
            this.Property(t => t.RF_Des).HasColumnName("RF_Des");
            this.Property(t => t.RF_Remark).HasColumnName("RF_Remark");
            this.Property(t => t.RF_Sort).HasColumnName("RF_Sort");
            this.Property(t => t.RF_BackFor).HasColumnName("RF_BackFor");
            this.Property(t => t.RF_CreateDate).HasColumnName("RF_CreateDate");
            this.Property(t => t.RF_State).HasColumnName("RF_State");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Role_Function)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
