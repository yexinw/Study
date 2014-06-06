using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Role_Function
    {
        public Role_Function()
        {
            this.Func_Relation = new List<Func_Relation>();
        }

        public string RF_ID { get; set; }
        public string U_ID { get; set; }
        public string RF_Name { get; set; }
        public Nullable<int> RF_Type { get; set; }
        public string RF_Des { get; set; }
        public string RF_Remark { get; set; }
        public Nullable<int> RF_Sort { get; set; }
        public string RF_BackFor { get; set; }
        public Nullable<System.DateTime> RF_CreateDate { get; set; }
        public Nullable<int> RF_State { get; set; }
        public virtual ICollection<Func_Relation> Func_Relation { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
