using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class Log_ActionMap : EntityTypeConfiguration<Log_Action>
    {
        public Log_ActionMap()
        {
            // Primary Key
            this.HasKey(t => t.LA_ID);

            // Properties
            this.Property(t => t.LA_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.LA_IP)
                .HasMaxLength(50);

            this.Property(t => t.LA_Mark)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Log_Action");
            this.Property(t => t.LA_ID).HasColumnName("LA_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.LA_Type).HasColumnName("LA_Type");
            this.Property(t => t.LA_CreateTime).HasColumnName("LA_CreateTime");
            this.Property(t => t.LA_IP).HasColumnName("LA_IP");
            this.Property(t => t.LA_Mark).HasColumnName("LA_Mark");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.Log_Action)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
