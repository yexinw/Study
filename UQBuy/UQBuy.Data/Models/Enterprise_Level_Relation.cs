using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Enterprise_Level_Relation
    {
        public string ESLR_ID { get; set; }
        public string EL_ID { get; set; }
        public string ES_ID { get; set; }
        public Nullable<int> ESLR_TimeLimit { get; set; }
        public Nullable<int> ESLR_Count { get; set; }
        public virtual Enterprise_Level Enterprise_Level { get; set; }
        public virtual Enterprise_Services Enterprise_Services { get; set; }
    }
}
