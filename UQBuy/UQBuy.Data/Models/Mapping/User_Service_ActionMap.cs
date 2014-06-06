using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class User_Service_ActionMap : EntityTypeConfiguration<User_Service_Action>
    {
        public User_Service_ActionMap()
        {
            // Primary Key
            this.HasKey(t => t.USA_ID);

            // Properties
            this.Property(t => t.USA_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.ES_ID)
                .HasMaxLength(36);

            this.Property(t => t.E_ID)
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("User_Service_Action");
            this.Property(t => t.USA_ID).HasColumnName("USA_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.ES_ID).HasColumnName("ES_ID");
            this.Property(t => t.E_ID).HasColumnName("E_ID");

            // Relationships
            this.HasOptional(t => t.Enterprise)
                .WithMany(t => t.User_Service_Action)
                .HasForeignKey(d => d.E_ID);
            this.HasOptional(t => t.Enterprise_Services)
                .WithMany(t => t.User_Service_Action)
                .HasForeignKey(d => d.ES_ID);
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.User_Service_Action)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
