using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class User_NoteMap : EntityTypeConfiguration<User_Note>
    {
        public User_NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.UN_ID);

            // Properties
            this.Property(t => t.UN_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.U_ID)
                .HasMaxLength(36);

            this.Property(t => t.UN_Title)
                .HasMaxLength(100);

            this.Property(t => t.UN_Content)
                .HasMaxLength(1000);

            this.Property(t => t.UN_Color)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("User_Note");
            this.Property(t => t.UN_ID).HasColumnName("UN_ID");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.UN_Title).HasColumnName("UN_Title");
            this.Property(t => t.UN_Content).HasColumnName("UN_Content");
            this.Property(t => t.UN_Color).HasColumnName("UN_Color");
            this.Property(t => t.UN_Status).HasColumnName("UN_Status");
            this.Property(t => t.UN_PageX).HasColumnName("UN_PageX");
            this.Property(t => t.UN_PageY).HasColumnName("UN_PageY");
            this.Property(t => t.UN_PageZ).HasColumnName("UN_PageZ");
            this.Property(t => t.UN_CreateDate).HasColumnName("UN_CreateDate");
            this.Property(t => t.UN_State).HasColumnName("UN_State");

            // Relationships
            this.HasOptional(t => t.Userbasic)
                .WithMany(t => t.User_Note)
                .HasForeignKey(d => d.U_ID);

        }
    }
}
