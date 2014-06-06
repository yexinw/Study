using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Enterprise_Level
    {
        public Enterprise_Level()
        {
            this.Enterprises = new List<Enterprise>();
            this.Enterprise_Level_Relation = new List<Enterprise_Level_Relation>();
        }

        public string EL_ID { get; set; }
        public string EL_Name { get; set; }
        public Nullable<int> EL_Value { get; set; }
        public virtual ICollection<Enterprise> Enterprises { get; set; }
        public virtual ICollection<Enterprise_Level_Relation> Enterprise_Level_Relation { get; set; }
    }
}
