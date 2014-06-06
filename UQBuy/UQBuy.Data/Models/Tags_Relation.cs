using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Tags_Relation
    {
        public string TR_ID { get; set; }
        public string UT_ID { get; set; }
        public string U_ID { get; set; }
        public Nullable<int> TR_Level { get; set; }
        public virtual User_Tags User_Tags { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
