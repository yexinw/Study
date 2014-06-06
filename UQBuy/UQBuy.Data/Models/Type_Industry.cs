using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Type_Industry
    {
        public Type_Industry()
        {
            this.Enterprises = new List<Enterprise>();
            this.Userbasics = new List<Userbasic>();
        }

        public string TI_ID { get; set; }
        public string U_ID { get; set; }
        public string TI_PID { get; set; }
        public string TI_Name { get; set; }
        public string TI_Code { get; set; }
        public Nullable<int> TI_Level { get; set; }
        public string TI_Remark { get; set; }
        public Nullable<int> TI_Sort { get; set; }
        public Nullable<System.DateTime> TI_CreateDate { get; set; }
        public Nullable<int> TI_State { get; set; }
        public virtual ICollection<Enterprise> Enterprises { get; set; }
        public virtual Userbasic Userbasic { get; set; }
        public virtual ICollection<Userbasic> Userbasics { get; set; }
    }
}
