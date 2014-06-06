using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class User_Role
    {
        public User_Role()
        {
            this.Func_Relation = new List<Func_Relation>();
            this.Role_Relation = new List<Role_Relation>();
        }

        public string UR_ID { get; set; }
        public string U_ID { get; set; }
        public string UR_Name { get; set; }
        public string UR_Code { get; set; }
        public Nullable<int> UR_Type { get; set; }
        public Nullable<System.DateTime> UR_CreateDate { get; set; }
        public Nullable<int> UR_State { get; set; }
        public virtual ICollection<Func_Relation> Func_Relation { get; set; }
        public virtual ICollection<Role_Relation> Role_Relation { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
