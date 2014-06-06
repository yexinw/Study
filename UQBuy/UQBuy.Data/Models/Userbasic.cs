using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Userbasic
    {
        public Userbasic()
        {
            this.Businesses = new List<Business>();
            this.Business_Action = new List<Business_Action>();
            this.Enterprises = new List<Enterprise>();
            this.Enterprise_Action = new List<Enterprise_Action>();
            this.Log_Action = new List<Log_Action>();
            this.Role_Function = new List<Role_Function>();
            this.Role_Relation = new List<Role_Relation>();
            this.Site_Message = new List<Site_Message>();
            this.Site_Message1 = new List<Site_Message>();
            this.Tags_Relation = new List<Tags_Relation>();
            this.Type_Industry = new List<Type_Industry>();
            this.User_Authentication = new List<User_Authentication>();
            this.User_Integral = new List<User_Integral>();
            this.User_Note = new List<User_Note>();
            this.User_Remark = new List<User_Remark>();
            this.User_Role = new List<User_Role>();
            this.User_Service_Action = new List<User_Service_Action>();
            this.User_Tags = new List<User_Tags>();
            this.User_Visitcard = new List<User_Visitcard>();
            this.User_Visitcard1 = new List<User_Visitcard>();
        }

        public string U_ID { get; set; }
        public string TI_ID { get; set; }
        public string E_ID { get; set; }
        public string U_Code { get; set; }
        public string U_LoginName { get; set; }
        public string U_PassWord { get; set; }
        public string U_Nick { get; set; }
        public string U_RealName { get; set; }
        public Nullable<int> U_Gender { get; set; }
        public string U_MobilePhone { get; set; }
        public string U_TelPhone { get; set; }
        public string U_Email { get; set; }
        public string U_IDCard { get; set; }
        public string U_QQ { get; set; }
        public string U_Interest { get; set; }
        public string U_LoginIP { get; set; }
        public string U_Token { get; set; }
        public Nullable<System.DateTime> U_CreateDate { get; set; }
        public string U_Photo { get; set; }
        public Nullable<int> U_EmailStatus { get; set; }
        public Nullable<int> U_MobileStatus { get; set; }
        public Nullable<int> U_IDCardStatus { get; set; }
        public Nullable<int> U_State { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
        public virtual ICollection<Business_Action> Business_Action { get; set; }
        public virtual ICollection<Enterprise> Enterprises { get; set; }
        public virtual Enterprise Enterprise { get; set; }
        public virtual ICollection<Enterprise_Action> Enterprise_Action { get; set; }
        public virtual ICollection<Log_Action> Log_Action { get; set; }
        public virtual ICollection<Role_Function> Role_Function { get; set; }
        public virtual ICollection<Role_Relation> Role_Relation { get; set; }
        public virtual ICollection<Site_Message> Site_Message { get; set; }
        public virtual ICollection<Site_Message> Site_Message1 { get; set; }
        public virtual ICollection<Tags_Relation> Tags_Relation { get; set; }
        public virtual ICollection<Type_Industry> Type_Industry { get; set; }
        public virtual Type_Industry Type_Industry1 { get; set; }
        public virtual ICollection<User_Authentication> User_Authentication { get; set; }
        public virtual ICollection<User_Integral> User_Integral { get; set; }
        public virtual ICollection<User_Note> User_Note { get; set; }
        public virtual ICollection<User_Remark> User_Remark { get; set; }
        public virtual ICollection<User_Role> User_Role { get; set; }
        public virtual ICollection<User_Service_Action> User_Service_Action { get; set; }
        public virtual ICollection<User_Tags> User_Tags { get; set; }
        public virtual ICollection<User_Visitcard> User_Visitcard { get; set; }
        public virtual ICollection<User_Visitcard> User_Visitcard1 { get; set; }
    }
}
