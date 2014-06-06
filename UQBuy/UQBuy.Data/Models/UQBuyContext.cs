using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using UQBuy.Data.Models.Mapping;

namespace UQBuy.Data.Models
{
    public partial class UQBuyContext : DbContext
    {
        static UQBuyContext()
        {
            Database.SetInitializer<UQBuyContext>(null);
        }

        public UQBuyContext()
            : base("Name=UQBuyContext")
        {
        }

        public DbSet<Business> Businesses { get; set; }
        public DbSet<Business_Action> Business_Action { get; set; }
        public DbSet<Business_Pic> Business_Pic { get; set; }
        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<Enterprise_Action> Enterprise_Action { get; set; }
        public DbSet<Enterprise_Level> Enterprise_Level { get; set; }
        public DbSet<Enterprise_Level_Relation> Enterprise_Level_Relation { get; set; }
        public DbSet<Enterprise_Services> Enterprise_Services { get; set; }
        public DbSet<Enterprise_Services_Action> Enterprise_Services_Action { get; set; }
        public DbSet<Func_Relation> Func_Relation { get; set; }
        public DbSet<Log_Action> Log_Action { get; set; }
        public DbSet<Role_Function> Role_Function { get; set; }
        public DbSet<Role_Relation> Role_Relation { get; set; }
        public DbSet<Site_Message> Site_Message { get; set; }
        public DbSet<Tags_Relation> Tags_Relation { get; set; }
        public DbSet<Type_Industry> Type_Industry { get; set; }
        public DbSet<User_Authentication> User_Authentication { get; set; }
        public DbSet<User_Integral> User_Integral { get; set; }
        public DbSet<User_Note> User_Note { get; set; }
        public DbSet<User_Remark> User_Remark { get; set; }
        public DbSet<User_Role> User_Role { get; set; }
        public DbSet<User_Service_Action> User_Service_Action { get; set; }
        public DbSet<User_Tags> User_Tags { get; set; }
        public DbSet<User_Visitcard> User_Visitcard { get; set; }
        public DbSet<Userbasic> Userbasics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BusinessMap());
            modelBuilder.Configurations.Add(new Business_ActionMap());
            modelBuilder.Configurations.Add(new Business_PicMap());
            modelBuilder.Configurations.Add(new EnterpriseMap());
            modelBuilder.Configurations.Add(new Enterprise_ActionMap());
            modelBuilder.Configurations.Add(new Enterprise_LevelMap());
            modelBuilder.Configurations.Add(new Enterprise_Level_RelationMap());
            modelBuilder.Configurations.Add(new Enterprise_ServicesMap());
            modelBuilder.Configurations.Add(new Enterprise_Services_ActionMap());
            modelBuilder.Configurations.Add(new Func_RelationMap());
            modelBuilder.Configurations.Add(new Log_ActionMap());
            modelBuilder.Configurations.Add(new Role_FunctionMap());
            modelBuilder.Configurations.Add(new Role_RelationMap());
            modelBuilder.Configurations.Add(new Site_MessageMap());
            modelBuilder.Configurations.Add(new Tags_RelationMap());
            modelBuilder.Configurations.Add(new Type_IndustryMap());
            modelBuilder.Configurations.Add(new User_AuthenticationMap());
            modelBuilder.Configurations.Add(new User_IntegralMap());
            modelBuilder.Configurations.Add(new User_NoteMap());
            modelBuilder.Configurations.Add(new User_RemarkMap());
            modelBuilder.Configurations.Add(new User_RoleMap());
            modelBuilder.Configurations.Add(new User_Service_ActionMap());
            modelBuilder.Configurations.Add(new User_TagsMap());
            modelBuilder.Configurations.Add(new User_VisitcardMap());
            modelBuilder.Configurations.Add(new UserbasicMap());
        }
    }
}
