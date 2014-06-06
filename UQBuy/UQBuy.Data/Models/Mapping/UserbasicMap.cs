using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace UQBuy.Data.Models.Mapping
{
    public class UserbasicMap : EntityTypeConfiguration<Userbasic>
    {
        public UserbasicMap()
        {
            // Primary Key
            this.HasKey(t => t.U_ID);

            // Properties
            this.Property(t => t.U_ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.TI_ID)
                .HasMaxLength(36);

            this.Property(t => t.E_ID)
                .HasMaxLength(36);

            this.Property(t => t.U_Code)
                .HasMaxLength(20);

            this.Property(t => t.U_LoginName)
                .HasMaxLength(50);

            this.Property(t => t.U_PassWord)
                .HasMaxLength(20);

            this.Property(t => t.U_Nick)
                .HasMaxLength(100);

            this.Property(t => t.U_RealName)
                .HasMaxLength(100);

            this.Property(t => t.U_MobilePhone)
                .HasMaxLength(20);

            this.Property(t => t.U_TelPhone)
                .HasMaxLength(20);

            this.Property(t => t.U_Email)
                .HasMaxLength(50);

            this.Property(t => t.U_IDCard)
                .HasMaxLength(50);

            this.Property(t => t.U_QQ)
                .HasMaxLength(20);

            this.Property(t => t.U_Interest)
                .HasMaxLength(1000);

            this.Property(t => t.U_LoginIP)
                .HasMaxLength(50);

            this.Property(t => t.U_Token)
                .HasMaxLength(50);

            this.Property(t => t.U_Photo)
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Userbasic");
            this.Property(t => t.U_ID).HasColumnName("U_ID");
            this.Property(t => t.TI_ID).HasColumnName("TI_ID");
            this.Property(t => t.E_ID).HasColumnName("E_ID");
            this.Property(t => t.U_Code).HasColumnName("U_Code");
            this.Property(t => t.U_LoginName).HasColumnName("U_LoginName");
            this.Property(t => t.U_PassWord).HasColumnName("U_PassWord");
            this.Property(t => t.U_Nick).HasColumnName("U_Nick");
            this.Property(t => t.U_RealName).HasColumnName("U_RealName");
            this.Property(t => t.U_Gender).HasColumnName("U_Gender");
            this.Property(t => t.U_MobilePhone).HasColumnName("U_MobilePhone");
            this.Property(t => t.U_TelPhone).HasColumnName("U_TelPhone");
            this.Property(t => t.U_Email).HasColumnName("U_Email");
            this.Property(t => t.U_IDCard).HasColumnName("U_IDCard");
            this.Property(t => t.U_QQ).HasColumnName("U_QQ");
            this.Property(t => t.U_Interest).HasColumnName("U_Interest");
            this.Property(t => t.U_LoginIP).HasColumnName("U_LoginIP");
            this.Property(t => t.U_Token).HasColumnName("U_Token");
            this.Property(t => t.U_CreateDate).HasColumnName("U_CreateDate");
            this.Property(t => t.U_Photo).HasColumnName("U_Photo");
            this.Property(t => t.U_EmailStatus).HasColumnName("U_EmailStatus");
            this.Property(t => t.U_MobileStatus).HasColumnName("U_MobileStatus");
            this.Property(t => t.U_IDCardStatus).HasColumnName("U_IDCardStatus");
            this.Property(t => t.U_State).HasColumnName("U_State");

            // Relationships
            this.HasOptional(t => t.Enterprise)
                .WithMany(t => t.Userbasics)
                .HasForeignKey(d => d.E_ID);
            this.HasOptional(t => t.Type_Industry1)
                .WithMany(t => t.Userbasics)
                .HasForeignKey(d => d.TI_ID);

        }
    }
}
